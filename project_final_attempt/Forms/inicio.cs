using project_final_attempt.Entities.Peliculas;
using project_final_attempt.Entities.Personajes;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_final_attempt.Forms
{
    public partial class inicio : Form
    {
        Lista_personajes lista_Personajes = new Lista_personajes();
        Lista_peliculas lista_Peliculas = new Lista_peliculas();
        
        List<Personaje> personajes = new List<Personaje>();
        List<Movie> peliculas = new List<Movie>();


        public void Abrirform(object form)
        {
            if (this.insidePanel.Controls.Count > 0)
                this.insidePanel.Controls.Clear();

            Form fh = form as Form;
            fh.AutoSize = false;
            fh.TopLevel = false;
            fh.Dock = insidePanel.Dock; 
            this.insidePanel.Controls.Add(fh);
            this.insidePanel.Tag = fh;
            
            fh.Show();
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            if (File.Exists(@".\data\DatosPersonaje.txt") && File.Exists(@".\data\DatosPeliculas.txt"))
            {
                personajes = lista_Personajes.personajes_desceralizados();
                peliculas = lista_Peliculas.descerealizar_pelicula();
                var (Dc, Marvel) = total_personajes(personajes);
                totalPeliculas.Text = Convert.ToString(peliculas.Count());
                totalPersonajes.Text = Convert.ToString(personajes.Count());
                TotalMarvel.Text = Convert.ToString(Marvel);
                TotalDC.Text = Convert.ToString(Dc);
            }
            else
            {
                File.Create(@".\data\DatosPersonaje.txt");
                File.Create(@".\data\DatosPeliculas.txt");
                totalPeliculas.Text = Convert.ToString(peliculas.Count());
                totalPersonajes.Text = Convert.ToString(personajes.Count());
            }
            lista_Personajes.garbage_colector();
            lista_Personajes.garbage_colector(@".\data\Backup\Backup-imagenes\", @".\data\Backup\Backup-datosPersonajes.txt");
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
            try
            {
                if (TotalDC.Text != "0" && TotalMarvel.Text != "0")
                {
                    Abrirform(new gestion_peliculas());
                }
                else { MessageBox.Show("Para poder empezar a agregar peliculas, tienes que agregar por lo menos un personaje de Marvel y uno de DC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception x) { Abrirform(new inicio()); }
        }

        private (int, int) total_personajes(List<Personaje> personajes)
        {
            int marvel = 0;
            int dc = 0;
            foreach (Personaje c in personajes)
            {
                if (c._universe == "Marvel")
                {
                    marvel++;
                }
                else { dc++; }
            }
            return (dc, marvel);
        }

        
    }
}
