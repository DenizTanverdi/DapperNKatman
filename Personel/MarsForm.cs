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

namespace Personel
{
    public partial class MarsForm : Form
    {
        SqlConnection con;
        public MarsForm()
        {
            InitializeComponent();
        }

        private void MarsForm_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=SEM-BILGISAYAR;Initial Catalog=NORTHWND2;User ID=test2 ;Password=test2;MultipleActiveResultSets=True";
            con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select distinct country from Customers", con);

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string country = rdr["country"].ToString();
                TreeNode countryNode = new TreeNode(country);
                treeView1.Nodes.Add(countryNode);

                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandText = "Select CompanyName from Customers Where country=@country";
                cmd2.Parameters.AddWithValue("@country", country);
                SqlDataReader rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                {
                    string customer = rdr2["CompanyName"].ToString();

                    TreeNode customerNode = new TreeNode(customer);
                    countryNode.Nodes.Add(customerNode);
                }

            }
        }
    }
}
