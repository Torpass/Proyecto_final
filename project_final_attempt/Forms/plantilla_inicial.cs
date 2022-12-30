using project_final_attempt.Forms;

namespace project_final_attempt
{
    public partial class plantilla_inicial : Form
    {
        private void Abrirform(object form)
        {
            if (this.insidePanel.Controls.Count > 0)
                this.insidePanel.Controls.RemoveAt(0);

            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = this.insidePanel.Dock;
            this.insidePanel.Controls.Add(fh);
            this.insidePanel.Tag = fh;
            fh.Show();
        }

        public plantilla_inicial()
        {
            InitializeComponent();
            siticoneShadowForm1.SetShadowForm(this);
            Abrirform(new inicio());
        }


        private void btnPersonajes_Click(object sender, EventArgs e)
        {
            Abrirform(new visualizar_personajes());
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {
            Abrirform(new inicio());
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
        }
    }

    
}