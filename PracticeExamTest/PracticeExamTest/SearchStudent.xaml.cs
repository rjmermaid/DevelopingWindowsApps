using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace PracticeExamTest
{
    /// <summary>
    /// Interaction logic for SearchStudent.xaml
    /// </summary>
    public partial class SearchStudent : Window
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, RoutedEventArgs e)
        {
            string connectionStr = "Server=IBTCOLLEGE.mssql.somee.com; Database=IBTCollege; User Id=ibtcollege_SQLLogin_1; Password=dd69kxzi3m";
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [Students] WHERE [FirstName]=@FirstName AND [LastName]=@LastName", conn);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                List<Student> results = new List<Student>();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Student info = new Student();
                    info.FirstName = reader["FirstName"].ToString();
                    info.LastName = reader["lastName"].ToString();
                    info.EmailAddress = reader["EmailAddress"].ToString();
                    results.Add(info);
                }
                reader.Close();
                dataGridView1.ItemsSource = results;
            }
        }
    }
}
