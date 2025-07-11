namespace Project8_RapidApiCurrency
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
            this.lbl_dolarsatis = new System.Windows.Forms.Label();
            this.lbl_euro_satis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_miktar = new System.Windows.Forms.TextBox();
            this.radioButton_d = new System.Windows.Forms.RadioButton();
            this.radioButton_e = new System.Windows.Forms.RadioButton();
            this.radioButton_s = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_toplam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lBL_STERLİN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_dolarsatis
            // 
            this.lbl_dolarsatis.AutoSize = true;
            this.lbl_dolarsatis.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dolarsatis.Location = new System.Drawing.Point(118, 136);
            this.lbl_dolarsatis.Name = "lbl_dolarsatis";
            this.lbl_dolarsatis.Size = new System.Drawing.Size(72, 24);
            this.lbl_dolarsatis.TabIndex = 0;
            this.lbl_dolarsatis.Text = "label1";
            this.lbl_dolarsatis.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_euro_satis
            // 
            this.lbl_euro_satis.AutoSize = true;
            this.lbl_euro_satis.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_euro_satis.Location = new System.Drawing.Point(118, 168);
            this.lbl_euro_satis.Name = "lbl_euro_satis";
            this.lbl_euro_satis.Size = new System.Drawing.Size(72, 24);
            this.lbl_euro_satis.TabIndex = 2;
            this.lbl_euro_satis.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "BİRİM MİKTARI :";
            // 
            // textBox_miktar
            // 
            this.textBox_miktar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_miktar.Location = new System.Drawing.Point(216, 48);
            this.textBox_miktar.Name = "textBox_miktar";
            this.textBox_miktar.Size = new System.Drawing.Size(181, 32);
            this.textBox_miktar.TabIndex = 5;
            // 
            // radioButton_d
            // 
            this.radioButton_d.AutoSize = true;
            this.radioButton_d.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton_d.Location = new System.Drawing.Point(227, 134);
            this.radioButton_d.Name = "radioButton_d";
            this.radioButton_d.Size = new System.Drawing.Size(114, 28);
            this.radioButton_d.TabIndex = 6;
            this.radioButton_d.TabStop = true;
            this.radioButton_d.Text = "$(dolar)";
            this.radioButton_d.UseVisualStyleBackColor = true;
            // 
            // radioButton_e
            // 
            this.radioButton_e.AutoSize = true;
            this.radioButton_e.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton_e.Location = new System.Drawing.Point(227, 166);
            this.radioButton_e.Name = "radioButton_e";
            this.radioButton_e.Size = new System.Drawing.Size(108, 28);
            this.radioButton_e.TabIndex = 7;
            this.radioButton_e.TabStop = true;
            this.radioButton_e.Text = "€(euro)";
            this.radioButton_e.UseVisualStyleBackColor = true;
            // 
            // radioButton_s
            // 
            this.radioButton_s.AutoSize = true;
            this.radioButton_s.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton_s.Location = new System.Drawing.Point(227, 198);
            this.radioButton_s.Name = "radioButton_s";
            this.radioButton_s.Size = new System.Drawing.Size(126, 28);
            this.radioButton_s.TabIndex = 8;
            this.radioButton_s.TabStop = true;
            this.radioButton_s.Text = "£(sterlin)";
            this.radioButton_s.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(431, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_toplam
            // 
            this.textBox_toplam.Enabled = false;
            this.textBox_toplam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_toplam.Location = new System.Drawing.Point(216, 86);
            this.textBox_toplam.Name = "textBox_toplam";
            this.textBox_toplam.Size = new System.Drawing.Size(181, 32);
            this.textBox_toplam.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "ÖDENECEK TUTAR :";
            // 
            // lBL_STERLİN
            // 
            this.lBL_STERLİN.AutoSize = true;
            this.lBL_STERLİN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBL_STERLİN.Location = new System.Drawing.Point(118, 200);
            this.lBL_STERLİN.Name = "lBL_STERLİN";
            this.lBL_STERLİN.Size = new System.Drawing.Size(72, 24);
            this.lBL_STERLİN.TabIndex = 12;
            this.lBL_STERLİN.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(101, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "RAPİD APİ İLE DÖVİZ KURU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(637, 246);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lBL_STERLİN);
            this.Controls.Add(this.textBox_toplam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton_s);
            this.Controls.Add(this.radioButton_e);
            this.Controls.Add(this.radioButton_d);
            this.Controls.Add(this.textBox_miktar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_euro_satis);
            this.Controls.Add(this.lbl_dolarsatis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dolarsatis;
        private System.Windows.Forms.Label lbl_euro_satis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_miktar;
        private System.Windows.Forms.RadioButton radioButton_d;
        private System.Windows.Forms.RadioButton radioButton_e;
        private System.Windows.Forms.RadioButton radioButton_s;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_toplam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lBL_STERLİN;
        private System.Windows.Forms.Label label3;
    }
}

