using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql; // Ensure you have the Npgsql package installed for PostgreSQL connectivity

namespace Project10_PostgreSql_ToDoListApp
{
    public partial class ToDoListApp : Form
    {
        public ToDoListApp()
        {
            InitializeComponent();
        }

        private void ToDoListApp_Load(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;port=5432;Database=DBproject10ToDoList;User Id=postgres;Password=123456");
            string query = "SELECT * FROM \"todolist\" ";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];




        }
    }
}