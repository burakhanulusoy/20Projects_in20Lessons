using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project16_MailRegister
{
    public partial class frmMailConfirm : Form
    {
        public frmMailConfirm()
        {
            InitializeComponent();
        }
        public int code;
        public string mail;
        Db_16_ProjectEntities db = new Db_16_ProjectEntities();


        private void btn_confirm_Click(object sender, EventArgs e)
        {  

            var x=db.tbl_user.Where(y => y.email ==mail).Select(m=>m.confirmcode).FirstOrDefault();
             if(x == txt_code.Text)
            {
              MessageBox.Show("Your email has been confirmed successfully.");
                var user = db.tbl_user.FirstOrDefault(y => y.email == mail);
                if (user != null)
                {
                    user.isConfirm = true; // Kullanıcının onay durumunu güncelle
                    db.SaveChanges(); // Değişiklikleri veritabanına kaydet
                }
                else
                {
                                       MessageBox.Show("User not found.");
                }


            }
            else
            {
                MessageBox.Show("The confirmation code is incorrect. Please try again.");
            }





        }

        private void frmMailConfirm_Load(object sender, EventArgs e)
        {
            txt_mail.Text = mail; // Form yüklendiğinde mail adresini göster
        }
    }
}
