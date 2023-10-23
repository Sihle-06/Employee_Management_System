using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employee_Management_System
{
    public partial class Organization : Form
    {
        private System.Windows.Forms.TreeView treeView;
        private SqlConnection sqlConnection;
        public Organization()
        {
            InitializeComponent();
            treeView = new System.Windows.Forms.TreeView();
            treeView.Dock = DockStyle.Fill;

            // Set up a SQL connection (modify the connection string as needed)
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\s993540\\OneDrive - Sanlam Life Insurance Limited\\Documents\\employee.mdf\";Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connectionString);

            // Populate the TreeView
            PopulateTreeView(0, null);

            // Add the TreeView to the form
            Controls.Add(treeView);
        }


        private void PopulateTreeView(int employeeID, TreeNode parentNode)
        {
            string query = "SELECT employeeID, firstName FROM employeeInfo WHERE employeeID = @employeeID";
            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@employeeID", employeeID);
                sqlConnection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TreeNode node = new TreeNode(reader["firstName"].ToString());
                        int childID = Convert.ToInt32(reader["employeeID"]);

                        // If there are child nodes, recursively populate them
                        PopulateTreeView(childID, node);

                        // Add the node to the parent node (or the TreeView root)
                        if (parentNode == null)
                            treeView.Nodes.Add(node);
                        else
                            parentNode.Nodes.Add(node);
                    }
                }
            }
        }
        private void Organization_Load(object sender, EventArgs e)
        {

        }
    }
}
