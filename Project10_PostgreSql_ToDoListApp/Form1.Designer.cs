namespace Project10_PostgreSql_ToDoListApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_priorty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbt_finished = new System.Windows.Forms.RadioButton();
            this.rdbtn_noFinish = new System.Windows.Forms.RadioButton();
            this.button_list = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.cmb_categry = new System.Windows.Forms.ComboBox();
            this.Btn_categ = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Id :";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(95, 26);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(218, 24);
            this.txt_id.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(95, 57);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(218, 24);
            this.txt_title.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Başlık :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori :";
            // 
            // txt_priorty
            // 
            this.txt_priorty.Location = new System.Drawing.Point(95, 116);
            this.txt_priorty.Name = "txt_priorty";
            this.txt_priorty.Size = new System.Drawing.Size(218, 24);
            this.txt_priorty.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Öncelik :";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(95, 146);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(218, 187);
            this.txt_description.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Açıklama :";
            // 
            // rdbt_finished
            // 
            this.rdbt_finished.AutoSize = true;
            this.rdbt_finished.Location = new System.Drawing.Point(48, 339);
            this.rdbt_finished.Name = "rdbt_finished";
            this.rdbt_finished.Size = new System.Drawing.Size(120, 22);
            this.rdbt_finished.TabIndex = 13;
            this.rdbt_finished.TabStop = true;
            this.rdbt_finished.Text = "Tamamlandı";
            this.rdbt_finished.UseVisualStyleBackColor = true;
            // 
            // rdbtn_noFinish
            // 
            this.rdbtn_noFinish.AutoSize = true;
            this.rdbtn_noFinish.Location = new System.Drawing.Point(190, 339);
            this.rdbtn_noFinish.Name = "rdbtn_noFinish";
            this.rdbtn_noFinish.Size = new System.Drawing.Size(134, 22);
            this.rdbtn_noFinish.TabIndex = 14;
            this.rdbtn_noFinish.TabStop = true;
            this.rdbtn_noFinish.Text = "Devam Ediyor";
            this.rdbtn_noFinish.UseVisualStyleBackColor = true;
            // 
            // button_list
            // 
            this.button_list.Location = new System.Drawing.Point(319, 98);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(235, 57);
            this.button_list.TabIndex = 15;
            this.button_list.Text = "Listele";
            this.button_list.UseVisualStyleBackColor = true;
            this.button_list.Click += new System.EventHandler(this.button_list_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(319, 26);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(235, 66);
            this.button_Add.TabIndex = 16;
            this.button_Add.Text = "Ekle";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(319, 161);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(235, 53);
            this.button_delete.TabIndex = 17;
            this.button_delete.Text = "Sil";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(319, 220);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(235, 53);
            this.button_update.TabIndex = 18;
            this.button_update.Text = "Güncelle";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // cmb_categry
            // 
            this.cmb_categry.FormattingEnabled = true;
            this.cmb_categry.Location = new System.Drawing.Point(95, 84);
            this.cmb_categry.Name = "cmb_categry";
            this.cmb_categry.Size = new System.Drawing.Size(218, 26);
            this.cmb_categry.TabIndex = 22;
            // 
            // Btn_categ
            // 
            this.Btn_categ.Location = new System.Drawing.Point(319, 279);
            this.Btn_categ.Name = "Btn_categ";
            this.Btn_categ.Size = new System.Drawing.Size(235, 54);
            this.Btn_categ.TabIndex = 23;
            this.Btn_categ.Text = "Kategori Listesi";
            this.Btn_categ.UseVisualStyleBackColor = true;
            this.Btn_categ.Click += new System.EventHandler(this.Btn_categ_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(560, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(823, 361);
            this.dataGridView1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1395, 399);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_categ);
            this.Controls.Add(this.cmb_categry);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_list);
            this.Controls.Add(this.rdbtn_noFinish);
            this.Controls.Add(this.rdbt_finished);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_priorty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Yapılacaklar Listesi  / To Do List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_priorty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbt_finished;
        private System.Windows.Forms.RadioButton rdbtn_noFinish;
        private System.Windows.Forms.Button button_list;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.ComboBox cmb_categry;
        private System.Windows.Forms.Button Btn_categ;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

