using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project12_JwtToken
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        public string token;
        DB_12_JWTEntities connection= new DB_12_JWTEntities();
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = token;


            var principal = new JWT.tokenvalidator().validateJWTToken(token);

            if(principal != null)
            {
              string name=principal.FindFirst(JwtRegisteredClaimNames.Sub)?.Value;
                MessageBox.Show("Welcome " + name);
                dataGridView1.DataSource=connection.tbl_employee.ToList();


            }
            else
            {
                dataGridView1.DataSource = connection.tbl_employee.ToList();

            }




        }
    }
}
