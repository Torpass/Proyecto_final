using project_final_attempt.Forms;

namespace project_final_attempt
{
    public partial class plantilla_inicial : Form
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
            try
            {
                Abrirform(new inicio());
            }
            catch (Exception x)
            {
                Abrirform(new inicio());
            }
        }


        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            Abrirform(new visualizar_peliculas());
        }


        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            File.Copy(@".\data\DatosPeliculas.txt", @".\data\Backup\Backup-datosPeliculas.txt", true);
            File.Copy(@".\data\DatosPersonaje.txt", @".\data\Backup\Backup-datosPersonajes.txt", true);
            string path_backup = @".\data\Backup\Backup-imagenes";
            string path_imagenes = Directory.GetCurrentDirectory() + @".\data\imagenes";
            if (!Directory.Exists(path_backup))
            {
                Directory.CreateDirectory(path_backup);
            }
            foreach (var file in Directory.GetFiles(path_imagenes))
            {
                File.Copy(file, Path.Combine(path_backup, Path.GetFileName(file)), true);
            }
        }
    }   
}