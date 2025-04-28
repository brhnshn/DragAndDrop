namespace Uyg1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstİllerA = new System.Windows.Forms.ListBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnRightAktar = new System.Windows.Forms.Button();
            this.btnLeftAktar = new System.Windows.Forms.Button();
            this.lstİllerB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(115, 136);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(100, 22);
            this.txtGiris.TabIndex = 0;
            this.txtGiris.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGiris_KeyDown);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(221, 136);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(115, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstİllerA
            // 
            this.lstİllerA.AllowDrop = true;
            this.lstİllerA.FormattingEnabled = true;
            this.lstİllerA.ItemHeight = 16;
            this.lstİllerA.Location = new System.Drawing.Point(115, 164);
            this.lstİllerA.Name = "lstİllerA";
            this.lstİllerA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstİllerA.Size = new System.Drawing.Size(221, 164);
            this.lstİllerA.TabIndex = 2;
            this.lstİllerA.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstİllerA_DragDrop);
            this.lstİllerA.DragOver += new System.Windows.Forms.DragEventHandler(this.lstİllerA_DragOver);
            this.lstİllerA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstİllerA_KeyDown);
            this.lstİllerA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstİllerA_MouseDown);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(115, 334);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(100, 54);
            this.btnGoster.TabIndex = 3;
            this.btnGoster.Text = "Seçilileri Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(221, 334);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 54);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Seçilileri Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnRightAktar
            // 
            this.btnRightAktar.Location = new System.Drawing.Point(384, 192);
            this.btnRightAktar.Name = "btnRightAktar";
            this.btnRightAktar.Size = new System.Drawing.Size(75, 23);
            this.btnRightAktar.TabIndex = 5;
            this.btnRightAktar.Text = ">>";
            this.btnRightAktar.UseVisualStyleBackColor = true;
            this.btnRightAktar.Click += new System.EventHandler(this.btnRightAktar_Click);
            // 
            // btnLeftAktar
            // 
            this.btnLeftAktar.Location = new System.Drawing.Point(384, 260);
            this.btnLeftAktar.Name = "btnLeftAktar";
            this.btnLeftAktar.Size = new System.Drawing.Size(75, 23);
            this.btnLeftAktar.TabIndex = 6;
            this.btnLeftAktar.Text = "<<";
            this.btnLeftAktar.UseVisualStyleBackColor = true;
            this.btnLeftAktar.Click += new System.EventHandler(this.btnLeftAktar_Click);
            // 
            // lstİllerB
            // 
            this.lstİllerB.AllowDrop = true;
            this.lstİllerB.FormattingEnabled = true;
            this.lstİllerB.ItemHeight = 16;
            this.lstİllerB.Location = new System.Drawing.Point(485, 164);
            this.lstİllerB.Name = "lstİllerB";
            this.lstİllerB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstİllerB.Size = new System.Drawing.Size(221, 164);
            this.lstİllerB.TabIndex = 7;
            this.lstİllerB.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstİllerB_DragDrop);
            this.lstİllerB.DragOver += new System.Windows.Forms.DragEventHandler(this.lstİllerB_DragOver);
            this.lstİllerB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstİllerB_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(148, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 69);
            this.label1.TabIndex = 8;
            this.label1.Text = "DRAG AND DROP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstİllerB);
            this.Controls.Add(this.btnLeftAktar);
            this.Controls.Add(this.btnRightAktar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lstİllerA);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtGiris);
            this.Name = "Form1";
            this.Text = "Drag And Drop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstİllerA;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnRightAktar;
        private System.Windows.Forms.Button btnLeftAktar;
        private System.Windows.Forms.ListBox lstİllerB;
        private System.Windows.Forms.Label label1;
    }
}

