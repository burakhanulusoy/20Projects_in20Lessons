using MailKit.Net.Smtp;
using MimeKit;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Db_16_ProjectEntities db = new Db_16_ProjectEntities();
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            Random a=new Random();
            int confirmCode = a.Next(100000, 999999);



            tbl_user user = new tbl_user();
            user.username = txt_name.Text;
            user.usersurname = txt_surname.Text;
            user.password = txt_password.Text;
            user.email = txt_mail.Text;
            user.password = txt_a_password.Text;
            user.isConfirm =false;
            user.confirmcode = confirmCode.ToString();
            if (txt_a_password.Text.Equals(txt_password.Text))
            {
                db.tbl_user.Add(user);
                db.SaveChanges();
                MessageBox.Show("Your registration is successful. Please check your email for confirmation code: " + confirmCode);

                #region Mail Sending Code

                MimeMessage mimeMessage = new MimeMessage();

                MailboxAddress mailboxAddress = new MailboxAddress("ADMİN", "burakhanulusoy18@gmail.com");
                mimeMessage.From.Add(mailboxAddress);  //gidecek yer   gönderen

                MailboxAddress to = new MailboxAddress("user", txt_mail.Text);
                mimeMessage.To.Add(to);  //gelen yer  ///alıcı


                var bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = "Your confirmation code is: " + confirmCode; //mesaj içeriği

                mimeMessage.Body = bodyBuilder.ToMessageBody();

                mimeMessage.Subject = "Confirmation Code"; //konu

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Connect("smtp.gmail.com", 587, false); //SMTP sunucusu ve port numarası
                smtpClient.Authenticate("burakhanulusoy18@gmail.com", "atikrrfaeyurvxpn"); //gönderen mail ve şifresi
                smtpClient.Send(mimeMessage); //mail gönderme
                smtpClient.Disconnect(true); //bağlantıyı kesme
                MessageBox.Show("Confirmation email sent successfully!");
                frmMailConfirm  frmMail =new frmMailConfirm();
                frmMail.code = confirmCode;
                frmMail.mail = txt_mail.Text;
                frmMail.Show();

                #endregion







            }



        }
    }
}
