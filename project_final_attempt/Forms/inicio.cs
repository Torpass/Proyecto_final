using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_final_attempt.Forms
{
    public partial class inicio : Form
    {
        private void Abrirform(object form)
        {
            if (this.insidePanel.Controls.Count > 0)
                this.insidePanel.Controls.Clear();

            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = insidePanel.Dock; 
            this.insidePanel.Controls.Add(fh);
            this.insidePanel.Tag = fh;
            
            fh.Show();
        }

        public inicio()
        {
            InitializeComponent();
        }

 
        private void btnGestionPersonajes_Click(object sender, EventArgs e)
        {
            Abrirform(new gestion_personajes());
        }

        private void btnGestionPeliculas_Click_1(object sender, EventArgs e)
        {
            Abrirform(new gestion_peliculas());
        }
    }
}
