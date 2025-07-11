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
    public partial class frmTokenGenerator : Form
    {
        public frmTokenGenerator()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            tokengenerator tokengenerator = new tokengenerator();
            string token = tokengenerator.jwtGenerateToken(txt_username.Text,textBox_mail.Text,txt_name.Text,textBox_surnama.Text);
            richTextBox1.Text = token;








        }
    }
}
