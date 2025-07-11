using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_EntityFrameworkProduct_DBfirst
{
    public partial class Frm_category : Form
    {
        public Frm_category()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        DB_2_project20Entities db=new DB_2_project20Entities();
        private void btn_listele_Click(object sender, EventArgs e)
        {
            Listele();



        }

        private void Listele()
        {
            var x = from item in db.tbl_category
                    select new
                    {
                        item.Category_id,
                        item.Category_name
                    };
            dataGridView1.DataSource = x.ToList();
        }

        private void Frm_category_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            tbl_category t = new tbl_category();
            t.Category_name = txt_ad.Text;
            db.tbl_category.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
            Listele();
            txt_ad.Clear();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            var x=db.tbl_category.Find(int.Parse(txt_id.Text));
            db.tbl_category.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi");        
            Listele();
            txt_id.Clear();
            txt_ad.Clear();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ad.Text=dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {

            var x=db.tbl_category.Find(int.Parse(txt_id.Text));
            x.Category_name = txt_ad.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi");
            Listele();
            txt_id.Clear();
            txt_ad.Clear();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {



        }
    }
}
