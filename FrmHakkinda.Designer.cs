namespace EditorApp
{
    partial class FrmHakkinda
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
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnTamam = new Button();
            label3 = new Label();
            lblGithubLink = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 82);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Brown;
            panel2.ForeColor = Color.DarkMagenta;
            panel2.Location = new Point(100, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(168, 4);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(274, 48);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 2;
            label2.Text = "v.1.0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pad;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(85, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 54);
            label1.TabIndex = 0;
            label1.Text = "EditorApp";
            // 
            // btnTamam
            // 
            btnTamam.BackColor = Color.CadetBlue;
            btnTamam.Cursor = Cursors.Hand;
            btnTamam.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnTamam.ForeColor = Color.White;
            btnTamam.Location = new Point(85, 312);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(169, 53);
            btnTamam.TabIndex = 1;
            btnTamam.Text = "Tamam";
            btnTamam.UseVisualStyleBackColor = false;
            btnTamam.Click += btnTamam_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(6, 104);
            label3.Name = "label3";
            label3.Size = new Size(314, 180);
            label3.TabIndex = 3;
            label3.Text = "Bu uygulama Torbalı Şehit Uzman Çavuş Harun Şenözüar MTAL Bilişim Bölümü Nesne Tabanlı Programlama dersinde tasarlanmıştır.";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblGithubLink
            // 
            lblGithubLink.Font = new Font("Verdana", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblGithubLink.Image = Properties.Resources.github_logo__1_;
            lblGithubLink.ImageAlign = ContentAlignment.BottomCenter;
            lblGithubLink.Location = new Point(67, 249);
            lblGithubLink.Name = "lblGithubLink";
            lblGithubLink.Size = new Size(220, 60);
            lblGithubLink.TabIndex = 5;
            lblGithubLink.TabStop = true;
            lblGithubLink.Text = "https://github.com/RissProg";
            // 
            // FrmHakkinda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(330, 377);
            Controls.Add(lblGithubLink);
            Controls.Add(label3);
            Controls.Add(btnTamam);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmHakkinda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditorApp Hakkında";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnTamam;
        private Label label3;
        private LinkLabel lblGithubLink;
    }
}