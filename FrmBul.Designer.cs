namespace EditorApp
{
    partial class FrmBul
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
            label1 = new Label();
            txtAranan = new TextBox();
            btnBul = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(144, 18);
            label1.TabIndex = 0;
            label1.Text = "Aranacak Metin";
            // 
            // txtAranan
            // 
            txtAranan.BackColor = Color.NavajoWhite;
            txtAranan.Location = new Point(162, 37);
            txtAranan.Name = "txtAranan";
            txtAranan.Size = new Size(236, 25);
            txtAranan.TabIndex = 1;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(280, 97);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(118, 36);
            btnBul.TabIndex = 2;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // FrmBul
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(417, 155);
            Controls.Add(btnBul);
            Controls.Add(txtAranan);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBul";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bul...";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAranan;
        private Button btnBul;
    }
}