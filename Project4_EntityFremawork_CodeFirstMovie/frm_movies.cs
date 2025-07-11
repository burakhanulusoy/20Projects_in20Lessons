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
    public partial class frm_movies : Form
    {
        public frm_movies()
        {
            InitializeComponent();
        }

        MovieContext movieContext = new MovieContext();
        private void frm_movies_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource= movieContext.Categories.ToList();
            comboBox1.DisplayMember = "CategoryNAME";
            comboBox1.ValueMember = "CategoryID";



        }

        private void listele()
        {

            var x=from item in movieContext.Movies
                    select new
                    {
                        item.MoviesID,
                        item.MovieNAME,
                        item.Duration,
                        item.Description,
                        item.CreatedDate,
                        Category = item.Category.CategoryNAME
                    };
            dataGridView1.DataSource = x.ToList();



        }


        private void btn_listele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            Movies movies   =new Movies();
            movies.MovieNAME = txt_ad.Text;
            movies.Duration = Convert.ToInt32(txt_sure.Text);
            movies.Description = txt_yorum.Text;
            movies.CreatedDate = Convert.ToDateTime(dateTimePicker1.Text);
            movies.CategoryID = Convert.ToInt32(comboBox1.SelectedValue);
            movieContext.Movies.Add(movies);
            movieContext.SaveChanges();
            MessageBox.Show("Film Eklendi");
            listele();




        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            var x=movieContext.Movies.Find(Convert.ToInt32(txt_id.Text));
            if (x != null)
            {
                movieContext.Movies.Remove(x);
                movieContext.SaveChanges();
                MessageBox.Show("Film Silindi");
                listele();
            }
            else
            {
                MessageBox.Show("Film Bulunamadı");
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text =dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_sure.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_yorum.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();





        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            var x = movieContext.Movies.Find(Convert.ToInt32(txt_id.Text));
            x.MovieNAME= txt_ad.Text;
            x.Duration = Convert.ToInt32(txt_sure.Text);
            x.Description = txt_yorum.Text;
            x.CreatedDate = Convert.ToDateTime(dateTimePicker1.Text);
            x.CategoryID = Convert.ToInt32(comboBox1.SelectedValue);
            movieContext.SaveChanges();
            MessageBox.Show("Film Güncellendi");
            listele();






        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            var x=movieContext.Movies.Where(y => y.MovieNAME.Contains(txt_ad.Text)).ToList();
            if (x.Count > 0)
            {
                dataGridView1.DataSource = x.Select(y => new
                {
                    y.MoviesID,
                    y.MovieNAME,
                    y.Duration,
                    y.Description,
                    y.CreatedDate,
                    Category = y.Category.CategoryNAME
                }).ToList();
            }
            else
            {
                MessageBox.Show("Film Bulunamadı");
                listele();
            }



        }
    }
}
