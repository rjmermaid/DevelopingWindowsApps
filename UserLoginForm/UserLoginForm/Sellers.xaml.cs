using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace UserLoginForm
{
    /// <summary>
    /// Interaction logic for Sellers.xaml
    /// </summary>
    public partial class Sellers : Window
    {
        private string ConnectionString = "workstation id=TodoListDB.mssql.somee.com;packet size=4096;user id=rj_mermaid_SQLLogin_1;pwd=6gordu3swm;data source=TodoListDB.mssql.somee.com;persist security info=False;initial catalog=TodoListDB";
        public Sellers()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Sellers", con);
            con.Open();
            List<Seller> str = new List<Seller>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Seller seller = new Seller();
                seller.id = dr["id"].ToString();
                seller.Age = dr["Age"].ToString();
                seller.Name = dr["Name"].ToString();
                seller.Phone = dr["Phone"].ToString();
                str.Add(seller);
            }
            dr.Close();
            dataGridView1.ItemsSource = str;
            con.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string qur = "INSERT INTO Sellers VALUES ('" + txtId.Text + "','" + txtName.Text + "','" + txtAge.Text + "','" + txtPhone.Text + "')";
            List<string> str = new List<string>();
            SqlCommand cmd = new SqlCommand(qur, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted sucessfully");
            txtId.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            txtPhone.Text = "";

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM Sellers WHERE id = '" + txtId.Text + "'", con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE Sellers SET Name = @Name, Age = @Age, Phone = @Phone WHERE id = @id", con))
                    {
                        command.Parameters.AddWithValue("@Name", txtName.Text);
                        command.Parameters.AddWithValue("@Age", txtAge.Text);
                        command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        private void ___btnExport__Click(object sender, RoutedEventArgs e)
        {
            string pathToFile = @"C:\Users\Daniyar\Documents\Sellers.txt";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Sellers", con);

            List<string> str = new List<string>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                str.Add(dr.GetValue(0).ToString());
            }
            dr.Close();

            if (File.Exists(pathToFile) == false)
            {
                File.Create(pathToFile);
            }
            using (StreamWriter sw = new StreamWriter(pathToFile))
            {
                foreach (string p in str)
                {
                    sw.WriteLine(p);
                }


                sw.Close();
            }
        }

        private void btnMove_Click(object sender, RoutedEventArgs e)
        {
            Products win2 = new Products();
            win2.Show();
        }
    }
    
}
