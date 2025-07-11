using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project19_TableStatusMomentary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); // Timer'ı başlat

            timer1.Interval = 2000; // 1 saniye aralıklarla tetiklenecek


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            var buttons= this.Controls.OfType<Button>().ToList();
            foreach (var button in buttons)
            {
                this.Controls.Remove(button);
            }

            Db19ProjectEntities db = new Db19ProjectEntities();


            var values = db.tbl_table.ToList();





            int buttonWeidth = 100;
            int buttonHeight = 50;
            int pedding = 10;
            int x = 10;
            int y = 10;

            for (int i = 0; i < values.Count; i++)
            {
                var item = values[i];
                Button button = new Button();
                button.Text = item.table_number.ToString();
                button.Size = new Size(buttonWeidth, buttonHeight);

                int column = i % 4; // 4 sütun
                int row = i / 4;    // kaçıncı satırda

                button.Location = new Point(
                    x + column * (buttonWeidth + pedding),
                    y + row * (buttonHeight + pedding)
                );

                button.BackColor = bool.Parse(item.status.ToString()) ? System.Drawing.Color.Green : System.Drawing.Color.Red;

                this.Controls.Add(button);

            }


        }
    }
}
