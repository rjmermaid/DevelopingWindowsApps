using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TournamentManagementSystem
{
    /// <summary>
    /// Interaction logic for Manage.xaml
    /// </summary>
    public partial class Manage : Window
    {
        private string ConnectionString = "workstation id=IBTCOLLEGE.mssql.somee.com;packet size=4096;user id=ibtcollege_SQLLogin_1;pwd=dd69kxzi3m;data source=IBTCOLLEGE.mssql.somee.com;persist security info=False;initial catalog=IBTCOLLEGE";
        public Manage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Teams", con);
            con.Open();
            List<Team> str = new List<Team>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Team product = new Team();
                product.TeamId = dr["TeamId"].ToString();
                product.TeamName = dr["TeamName"].ToString();
                product.CoachName = dr["CoachName"].ToString();
                product.CreatedBy = dr["CreatedBy"].ToString();
                product.DirectorName = dr["DirectorName"].ToString();
                product.AddressLine1 = dr["AddressLine1"].ToString();
                product.AddressLine2 = dr["AddressLine2"].ToString();
                product.PostCode = dr["PostCode"].ToString();
                product.City = dr["City"].ToString();
                product.ContactNumber = dr["ContactNumber"].ToString();
                product.EmailAddress = dr["EmailAddress"].ToString();
                str.Add(product);
            }
            dr.Close();
            DataGridView1.ItemsSource = str;
            con.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string qur = "INSERT INTO Teams VALUES ('" + txtId.Text + "','" + txtName.Text + "','" + txtCoachName.Text + "','" + txtDirectorName.Text + "','" + txtAddressLine1.Text + "','" + txtAddressLine2.Text + "','" + txtEmail.Text + "','" + txtCity.Text + "','" + txtCode.Text + "','" + txtNumber.Text + "','" + txtCreatedBy.Text + "',)";
            SqlCommand cmd = new SqlCommand(qur, con);
            cmd.ExecuteNonQuery();
            con.Close();

            // Firstly was trying this
            /*
      * foreach(Control c in this.Controls)
        {
            
            if(this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Empty");
            }
        } 
             */

            MessageBox.Show("Inserted sucessfully");
            txtId.Text = "";
            txtName.Text = "";
            txtCoachName.Text = "";
            txtDirectorName.Text = "";
            txtAddressLine1.Text = "";
            txtAddressLine2.Text = "";
            txtEmail.Text = "";
            txtCity.Text = "";
            txtCode.Text = "";
            txtNumber.Text = "";
            txtCreatedBy.Text = "";
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE Teams SET TeamName = @TeamName, CoachName = @CoachName, DirectorName = @DirectorName, AddressLine1 = @AddressLine1, AddressLine2 = @AddressLine2, EmailAddress = @EmailAddress, City = @City, PostCode = @PostCode, ContactNumber = @ContactNumber, CreatedBy = @CreatedBy WHERE TeamId = @TeamId", con))
                    {
                        command.Parameters.AddWithValue("@TeamName", txtName.Text);
                        command.Parameters.AddWithValue("@CoachName", txtCoachName.Text);
                        command.Parameters.AddWithValue("@DirectorName", txtDirectorName.Text);
                        command.Parameters.AddWithValue("@AddressLine1", txtAddressLine1.Text);
                        command.Parameters.AddWithValue("@AddressLine2", txtAddressLine2.Text);
                        command.Parameters.AddWithValue("@EmailAddress", txtEmail.Text);
                        command.Parameters.AddWithValue("@City", txtCity.Text);
                        command.Parameters.AddWithValue("@PostCode", txtCode.Text);
                        command.Parameters.AddWithValue("@ContactNumber", txtNumber.Text);
                        command.Parameters.AddWithValue("@CreatedBy", txtCreatedBy.Text);
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
                    using (SqlCommand command = new SqlCommand("DELETE FROM Teams WHERE TeamId = '" + txtId.Text + "'", con))
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
            string pathToFile = @"‪C:\haha\TEAMLIST.txt";
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

        private void txtName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            if (regex.IsMatch(txtName.Text))
            {
                MessageBox.Show("Invalid Input !");
            }
        }

        private void txtCoachName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            if (regex.IsMatch(txtCoachName.Text))
            {
                MessageBox.Show("Invalid Input !");
            }
        }
    }
}
