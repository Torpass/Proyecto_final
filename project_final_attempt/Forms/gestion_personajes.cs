using project_final_attempt.Entities.Personajes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_final_attempt.Forms
{
    public partial class gestion_personajes : Form
    {
        private String ruta_imagen = @".\data\imagenes\";
        private Lista_personajes personajes = new Lista_personajes();

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

        public gestion_personajes()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Abrirform(new inicio());
        }

        private void ImagenPersonaje_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagenes|*.jpg; *.png; *.jpge";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            dialog.Title = "Selecionar Imagen";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImagenPersonaje.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Personaje aux = new Personaje();

            aux._name = txtNombre.Text;
            aux._age = Convert.ToInt16(txtEdad.Text);
            aux._sex = txtSexo.Text;
            aux._rol = txtActitud.Text;
            aux._identity = txtIdentidad.Text;
            aux._universe = txtUniverso.Text;
            aux._img = $"{aux._name}.jpeg";
            ruta_imagen += $"{aux._img}";
            if (btnTrue.Checked == true) { aux._activity = true; } else { aux._activity = false; }
            ImagenPersonaje.Image.Save(ruta_imagen, ImageFormat.Jpeg);

            personajes.heroe_create(aux);
            personajes.serealizar_personaje();
            MessageBox.Show("Datos almacenados en el Archivo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
