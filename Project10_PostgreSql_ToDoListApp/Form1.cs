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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_categ_Click(object sender, EventArgs e)
        {
            frmCaategories frmCaategories = new frmCaategories();
            frmCaategories.Show();

        }

        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;port=5432;Database=DBproject10ToDoList;User Id=postgres;Password=123456");

        private void ALLlist()
        {
            string query = "select * from \"todolist\"";

            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connection.Close();



        }


        private void button_list_Click(object sender, EventArgs e)
        {
            ALLlist();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ALLlist ();

            //cmb
            string query = "select * from \"categories\"";
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            cmb_categry.DataSource = dataSet.Tables[0];
            cmb_categry.DisplayMember = "categoryname"; // Displayed column
            cmb_categry.ValueMember = "categoryid"; // Value column
            connection.Close();


        }

        private void button_Add_Click(object sender, EventArgs e)
        { 
            control();
            connection.Open();  
            string query = "INSERT INTO \"todolist\" (title,description,categoriesid,status,priority ) VALUES (@p1, @p2, @p3, @p4, @p5)";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", txt_title.Text);
            command.Parameters.AddWithValue("@p2", txt_description.Text);
            command.Parameters.AddWithValue("@p3", Convert.ToInt32(cmb_categry.SelectedValue));
            command.Parameters.AddWithValue("@p4",cont );
            command.Parameters.AddWithValue("@p5", txt_priorty.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Görev Eklendi");
            ALLlist();
        }

        bool cont;
        private void control()
        {
            if (rdbt_finished.Checked)
            {
                cont = true;
            }
            else if (rdbtn_noFinish.Checked)
            {
                cont = false;
            }
            else
            {
                MessageBox.Show("Lütfen Durum Seçiniz");
                cont = false;


            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "DELETE FROM \"todolist\" WHERE todolistid = @p1";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", Convert.ToInt32(txt_id.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Görev Silindi");









        }

        private void button_update_Click(object sender, EventArgs e)
        {

            connection.Open();
            string query = "UPDATE \"todolist\" SET title = @p1, description = @p2, categoriesid = @p3, status = @p4, priority = @p5 WHERE todolistid = @p6";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@p1", txt_title.Text);
            command.Parameters.AddWithValue("@p2", txt_description.Text);
            command.Parameters.AddWithValue("@p3", Convert.ToInt32(cmb_categry.SelectedValue));
            control();
            command.Parameters.AddWithValue("@p4", cont);
            command.Parameters.AddWithValue("@p5", txt_priorty.Text);
            command.Parameters.AddWithValue("@p6", Convert.ToInt32(txt_id.Text));
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Görev Güncellendi");
            ALLlist();



        }
    }
}
