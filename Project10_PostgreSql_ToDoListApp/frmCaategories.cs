using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10_PostgreSql_ToDoListApp
{
    public partial class frmCaategories : Form
    {
        public frmCaategories()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;port=5432;Database=DBproject10ToDoList;User Id=postgres;Password=123456");

        private void listele()
        {
            string query = "SELECT * FROM \"categories\" ";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void button_list_Click(object sender, EventArgs e)
        {

           listele();


        }

        private void frmCaategories_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "INSERT INTO \"categories\" (categoryname) VALUES (@p1)";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", txt_name.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kategori Eklendi");




        }

        private void button_remove_Click(object sender, EventArgs e)
        {

            connection.Open();
            string query = "DELETE FROM \"categories\" WHERE categoryid=@p1";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", Convert.ToInt32(txt_id.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kategori Silindi");






        }

        private void button_update_Click(object sender, EventArgs e)
        {

            connection.Open();
            string query = "UPDATE \"categories\" SET categoryname=@p1 WHERE categoryid=@p2";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", txt_name.Text);
            command.Parameters.AddWithValue("@p2", Convert.ToInt32(txt_id.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kategori Güncellendi");




        }

        private void btn_idreference_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT * FROM \"categories\" WHERE categoryid=@p1";
           
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1",int.Parse( txt_id.Text));
           
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
           
            dataGridView1.DataSource = dataTable;




        }
    }
}
