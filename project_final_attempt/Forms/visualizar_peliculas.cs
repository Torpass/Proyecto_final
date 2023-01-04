using project_final_attempt.Entities.Peliculas;
using project_final_attempt.Entities.Personajes;
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
    public partial class visualizar_peliculas : Form
    {

        static Lista_peliculas Peliculas = new Lista_peliculas();
        static Lista_personajes personajes = new Lista_personajes();

        List<Personaje> personajes_agregados = personajes.personajes_desceralizados(); 
        List <Movie> peliculas_agregadas= Peliculas.descerealizar_pelicula();

        List<Movie> peliculas_dc = new List<Movie>();
        List<Movie> peliculas_marvel = new List<Movie>();


        public visualizar_peliculas()
        {
            InitializeComponent();
            btnPersonaje.DataSource = nombres_personajes();
            mostrar_gridview(peliculas_agregadas);
            universo_personajes();

        }


        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            mostrar_gridview(peliculas_agregadas);
            txtBuscar.Enabled = true;
        }


        private void txtBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Año de presentancion") { ContenedorPersonaje.Visible = false; ContenedorRecaudo.Visible = false; ContenedorUniverso.Visible = false; ContenedorYear.Visible = true; }
            if (txtBuscar.Text == "Universo") { ContenedorPersonaje.Visible = false; ContenedorRecaudo.Visible = false; ContenedorYear.Visible = false; ContenedorUniverso.Visible = true; }
            if (txtBuscar.Text == "Monto recaudado") { ContenedorPersonaje.Visible = false; ContenedorYear.Visible = false; ContenedorUniverso.Visible = false; ContenedorRecaudo.Visible = true; }
            if (txtBuscar.Text == "Personaje") { ContenedorRecaudo.Visible = false; ContenedorYear.Visible = false; ContenedorUniverso.Visible = false; ContenedorPersonaje.Visible = true; }
        }


        private void btnBuscarYear_Click(object sender, EventArgs e)
        {
            List<Movie> rango = rango_year(Convert.ToInt16(year_1.Value), Convert.ToInt16(year_2.Value));
            mostrar_gridview(rango);
        }


        private void btnBuscarMonto_Click(object sender, EventArgs e)
        {
            List<Movie> monto = pelicua_monto(Convert.ToDecimal(txtMonto.Value));
            mostrar_gridview(monto);
        }


        private void btnUniverso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnUniverso.Text == "Marvel") { mostrar_gridview(peliculas_marvel); }
            if (btnUniverso.Text == "DC") { mostrar_gridview(peliculas_dc); }
        }


        private void btnPersonaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrar_gridview(movie_personaje(btnPersonaje.Text));
        }


        private void mostrar_gridview(List<Movie> mostrar)
        {
            DataGridView.Rows.Clear();
            foreach (Movie agregar in mostrar)
            {
                int rowindex = DataGridView.Rows.Add();
                DataGridView.Rows[rowindex].Cells[0].Value = agregar._name.ToString();
                DataGridView.Rows[rowindex].Cells[1].Value = agregar._year.ToString();
                DataGridView.Rows[rowindex].Cells[2].Value = agregar._universe.ToString();
                DataGridView.Rows[rowindex].Cells[3].Value = linea_directores(agregar._directors);
                DataGridView.Rows[rowindex].Cells[4].Value = agregar._amount.ToString();
                DataGridView.Rows[rowindex].Cells[5].Value = linea_personajes(agregar);
            }
        }


        private List<Movie> movie_personaje(string nombre_personaje)
        {
            List<Movie> pelicula_personaje = new List<Movie>();

            foreach (Movie x in peliculas_agregadas)
            {
                foreach (Personaje j in x._casting)
                {
                    if (j._name == nombre_personaje)
                    {
                        pelicula_personaje.Add(x);
                    }
                }
            }
            return pelicula_personaje;
        }


        public string linea_personajes(Movie Pelicula)
        {
            string linea_personajes = string.Empty;
            foreach (Personaje aux in Pelicula._casting)
            {
                linea_personajes += aux._name + ", ";
            }
            return linea_personajes;
        }


        public string linea_directores(List<string> Directores)
        {
            string linea_directores = string.Empty;
            foreach (string aux in Directores)
            {
                linea_directores += aux + ", ";
            }
            return linea_directores;
        }


        private void universo_personajes()
        {
            foreach (Movie x in peliculas_agregadas)
            {
                if (x._universe == "Marvel") { peliculas_marvel.Add(x); } else { peliculas_dc.Add(x); }
            }
        }


        private List<Movie> rango_year(int year_1, int year_2)
        {
            List<Movie> pelicula_rango = new List<Movie>();

            foreach (Movie aux in peliculas_agregadas)
            {
                if (aux._year >= year_1 && aux._year <= year_2 || aux._year >= year_2 && aux._year <= year_1)
                {
                    pelicula_rango.Add(aux);
                }
            }
            return pelicula_rango;
        }


        private List<Movie> pelicua_monto(decimal monto)
        {
            List<Movie> pelicula_monto = new List<Movie>();
            foreach (Movie aux in peliculas_agregadas)
            {
                if (Convert.ToDecimal(aux._amount) >= monto)
                {
                    pelicula_monto.Add(aux);
                }
            }
            return pelicula_monto;
        }


        private List<string> nombres_personajes()
        {
            List<string> nombre_personajes = new List<string>();

            foreach (Personaje x in personajes_agregados)
            {
                nombre_personajes.Add(x._name);
            }
            return nombre_personajes;
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Abrirform(new inicio());
        }


        private void Abrirform(object form)
        {
            if (this.insidePanel.Controls.Count > 0)
                this.insidePanel.Controls.Clear();

            Form fh = form as Form;
            fh.TopLevel = false;
            insidePanel.Dock = fh.Dock;
            this.insidePanel.Controls.Add(fh);

            fh.Show();
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cargar la copia de seguridad anterior para visualizar los datos de las Peliculas?","Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                List<Movie> backup_peliculas = Peliculas.descerealizar_pelicula(@".\data\Backup\backup-datosPeliculas.txt");
                if (backup_peliculas.Count() > 0)
                {
                    mostrar_gridview(backup_peliculas);
                    txtBuscar.Enabled = false;
                }else { MessageBox.Show("No se ha registrado ningun Backup reciente","Error",MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
