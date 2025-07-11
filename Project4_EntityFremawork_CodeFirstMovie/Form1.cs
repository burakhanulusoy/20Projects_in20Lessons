using Project4_EntityFremawork_CodeFirstMovie.DAL.Context;
using Project4_EntityFremawork_CodeFirstMovie.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_EntityFremawork_CodeFirstMovie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MovieContext movieContext = new MovieContext();
        private void btn_listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=movieContext.Categories.ToList();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryNAME=txt_ad.Text;
            movieContext.Categories.Add(category);
            movieContext.SaveChanges();
            MessageBox.Show("Kategori Eklendi");

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            var x=movieContext.Categories.Find(Convert.ToInt32(txt_id.Text));
            if (x != null)
            {
                movieContext.Categories.Remove(x);
                movieContext.SaveChanges();
                MessageBox.Show("Kategori Silindi");
            }
            else
            {
                MessageBox.Show("Kategori Bulunamadı");
            }



        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {

            var x=movieContext.Categories.Find(Convert.ToInt32(txt_id.Text));
            if (x != null)
            {
                x.CategoryNAME = txt_ad.Text;
                movieContext.SaveChanges();
                MessageBox.Show("Kategori Güncellendi");
            }
            else
            {
                MessageBox.Show("Kategori Bulunamadı");
            }




        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            var x = movieContext.Categories.Where(c => c.CategoryNAME.Contains(txt_ad.Text)).ToList();
            if (x.Count > 0)
            {
                dataGridView1.DataSource = x;
            }
            else
            {
                MessageBox.Show("Kategori Bulunamadı");
                dataGridView1.DataSource = null;
            }
        }
    }
}
