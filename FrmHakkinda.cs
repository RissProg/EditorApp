using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EditorApp
{
    public partial class FrmHakkinda : Form
    {
        public FrmHakkinda()
        {
            InitializeComponent();

            // **LinkLabel Kullanıyoruz!**
            lblGithubLink.Text = "GitHub Projesi / Profilim ";
            lblGithubLink.Links.Add(0, lblGithubLink.Text.Length, "https://github.com/RissProg/EditorApp");

            // **LinkLabel'in LinkClicked Olayını Bağlıyoruz**
            lblGithubLink.LinkClicked += new LinkLabelLinkClickedEventHandler(lblGithubLink_LinkClicked);
        }

        private void lblGithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(url))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            Close(); // Formu kapat
        }
    }
}
