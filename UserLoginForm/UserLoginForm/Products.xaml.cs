using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UserLoginForm
{
    /// <summary>
    /// Interaction logic for Products.xaml
    /// </summary>
    public partial class Products : Window
    {
        private string ConnectionString = "workstation id=TodoListDB.mssql.somee.com;packet size=4096;user id=rj_mermaid_SQLLogin_1;pwd=6gordu3swm;data source=TodoListDB.mssql.somee.com;persist security info=False;initial catalog=TodoListDB";
        public Products()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products", con);
            con.Open();
            List<Product> str = new List<Product>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Product product = new Product();
                product.id = dr["id"].ToString();
                product.Name = dr["Name"].ToString();
                product.Quantity = dr["Quantity"].ToString();
                product.Price = dr["Price"].ToString();
                str.Add(product);
            }
            dr.Close();
            dataGridView1.ItemsSource = str;
            con.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string qur = "INSERT INTO Products VALUES ('" + txtId.Text + "','" + txtName.Text + "','" + txtQuantity.Text + "','" + txtPrice.Text + "')";
            List<string> str = new List<string>();
            SqlCommand cmd = new SqlCommand(qur, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted sucessfully");
            txtId.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE Sellers SET Name = @Name, Quantity = @Quantity, Price = @Price WHERE id = @id", con))
                    {
                        command.Parameters.AddWithValue("@Name", txtName.Text);
                        command.Parameters.AddWithValue("@Age", txtQuantity.Text);
                        command.Parameters.AddWithValue("@Phone", txtPrice.Text);
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

        private void btnExport_Click(object sender, RoutedEventArgs e)
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
            Sellers win2 = new Sellers();
            win2.Show();
        }
    }
    
}
