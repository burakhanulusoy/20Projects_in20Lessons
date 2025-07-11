using Project12_JwtToken.JWT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project12_JwtToken
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        DB_12_JWTEntities con=new DB_12_JWTEntities();
        private void button_login_Click(object sender, EventArgs e)
        {
            tokengenerator tokengenerator = new tokengenerator();

            var user = con.tbl_user.FirstOrDefault(x => x.username == textBox_name.Text && x.password == textBox_passsword.Text);
            if(user != null)
            {

                string token = tokengenerator.jwtGenerateToken2(textBox_name.Text);
              //  MessageBox.Show("Token: " + token);






                frmEmployee frmEmployee = new frmEmployee();
                frmEmployee.token = token;
                frmEmployee.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
          

        }
    }
}
