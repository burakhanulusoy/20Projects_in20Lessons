using Dapper;
using Project5_DapperNorthwind.DTOS.CategoryDTOS;
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

namespace Project5_DapperNorthwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection1 = new SqlConnection(@"Data Source=ULUSOY;Initial Catalog=DB_5_20projects_northwind;Integrated Security=True");
     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    

        private async  void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Categories";
            var values = await connection1.QueryAsync<CategoryDto>(query);
            dataGridView1.DataSource = values;
        }

        private async void btn_ekle_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Categories (CategoryName, Description) VALUES (@CategoryName, @Description)";
            var parametre = new DynamicParameters();
            parametre.Add("@CategoryName",textBox1.Text);
            parametre.Add("@Description", textBox2.Text);
            await connection1.ExecuteAsync(query, parametre);
        }

        private async void btn_Sil_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Categories WHERE CategoryID = @CategoryID";
            var parametre = new DynamicParameters();
            parametre.Add("@CategoryID", Convert.ToInt32(textBox3.Text));
            await connection1.ExecuteAsync(query, parametre);

        }

     
        private async void btn_upd_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Categories SET CategoryName = @CategoryName, Description = @Description WHERE CategoryID = @CategoryID";
            var parametre = new DynamicParameters();
            parametre.Add("@CategoryID", Convert.ToInt32(textBox3.Text));
            parametre.Add("@CategoryName", textBox1.Text);
            parametre.Add("@Description", textBox2.Text);
            await connection1.ExecuteAsync(query, parametre);
        }
    }
}
