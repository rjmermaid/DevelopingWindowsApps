﻿using System;
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

namespace PracticeExamTest
{
    /// <summary>
    /// Interaction logic for ExportStudent.xaml
    /// </summary>
    public partial class ExportStudent : Window
    {
        public ExportStudent()
        {
            InitializeComponent();
        }

        private void btn_Export_Click(object sender, RoutedEventArgs e)
        {
            string pathToFile = @"C:\Students Exported.txt";
            string connectionStr = "Server=IBTCOLLEGE.mssql.somee.com; Database=IBTCollege; User Id=ibtcollege_SQLLogin_1; Password=dd69kxzi3m";

            List<string> str = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Students", conn);


                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    str.Add(dr.GetValue(0).ToString());
                    str.Add(dr.GetValue(1).ToString());
                    str.Add(dr.GetValue(2).ToString());
                    str.Add(dr.GetValue(3).ToString());
                }
                dr.Close();
            }
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
    }
}
