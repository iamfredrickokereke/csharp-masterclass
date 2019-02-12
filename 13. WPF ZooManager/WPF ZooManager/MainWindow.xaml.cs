﻿using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WPF_ZooManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();

            //SQL string
            string connectionString = ConfigurationManager.ConnectionStrings["WPF_ZooManager.Properties.Settings.MantasDBConnectionString"].ConnectionString;

            sqlConnection = new SqlConnection(connectionString);

            ShowZoos();
        }

        private void ShowZoos()
        {
            string query = "select * from Zoo";
            // the SqlDataAdapter can be imagined like an Interface to make Tables usable by c#-Objects
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

            using(sqlDataAdapter)
            {
                DataTable zooTable = new DataTable();

                sqlDataAdapter.Fill(zooTable);

                //Which information of the Table in DataTable should be shown in our ListBox?
                listZoos.DisplayMemberPath = "Location";
                //Which Value should be delivered when an Item form our listBox is selected?
                listZoos.SelectedValuePath = "Id";
                //The reference to the Data the ListBox should populate
                listZoos.ItemsSource = zooTable.DefaultView;
            }
        }
    }
}
