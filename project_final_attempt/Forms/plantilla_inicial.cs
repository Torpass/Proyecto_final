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

            fh.Show();
        }


        private void Abrirform_(object form)
        {
            if (this.insidePanel.Controls.Count > 0)
                this.insidePanel.Controls.Clear();

            Form fh = form as Form;
            fh.TopLevel = false;
            insidePanel.Dock = fh.Dock;
            this.insidePanel.Controls.Add(fh);

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
            try
            {
                Abrirform_(new visualizar_personajes());
            }
            catch(Exception x) { Abrirform_(new inicio()); }
        }


        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            Abrirform_(new visualizar_peliculas());
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que deseas salir del programa, la copia de seguridad se generará automáticamente?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (Directory.Exists(@".\data\Backup"))
                    {
                        File.Copy(@".\data\DatosPeliculas.txt", @".\data\Backup\Backup-datosPeliculas.txt", true);
                        File.Copy(@".\data\DatosPersonaje.txt", @".\data\Backup\Backup-datosPersonajes.txt", true);
                    }
                    else
                    {
                        Directory.CreateDirectory(@".\data\Backup");
                    }

                    string path_backup_imagenes = @".\data\Backup\Backup-imagenes";
                    string path_imagenes = Directory.GetCurrentDirectory() + @".\data\imagenes";
                    if (!Directory.Exists(path_backup_imagenes))
                    {
                        Directory.CreateDirectory(path_backup_imagenes);
                    }
                    if (Directory.Exists(@".\data\imagenes"))
                    {
                        foreach (var file in Directory.GetFiles(path_imagenes))
                        {
                            try
                            {
                                File.Copy(file, Path.Combine(path_backup_imagenes, Path.GetFileName(file)), true);
                            }
                            catch (System.Exception x) { Application.Exit(); }
                        }
                    }
                    else { Application.Exit(); }

                    Application.Exit();
                }
            }
            catch (Exception x) { Application.Exit(); }
           
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Abrirform_(new inicio());
            }
            catch
            {
                Abrirform_(new inicio());
            }
        }
    }   
}