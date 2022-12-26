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
    public partial class gestion_peliculas : Form
    {
        static Lista_personajes personajes = new Lista_personajes();
        Lista_peliculas pelis = new Lista_peliculas();
        List<string> nombre_directores = new List<string>();
        List<string> nombre_personajes = new List<string>();
        List<Personaje> personajes_ingresados = personajes.personajes_desceralizados();

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


        public gestion_peliculas()
        {
            InitializeComponent();
            List<string> nombre_personajes = new List<string>();

            foreach (Personaje aux in personajes_ingresados)
            {
                nombre_personajes.Add(aux._name.ToString());
            }
            txtPersonajes.DataSource = null;
            txtPersonajes.DataSource = nombre_personajes;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Abrirform(new inicio());
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            List<Personaje> personajes_pelicula = new List<Personaje>();
            Movie Movie_aux = new Movie();


            if (!buscar(txtNombre.Text))
            {
                //Selecciona todos los personajes ingresados por el usuario
                foreach (Personaje perosnaje_seleccionado in personajes_ingresados)
                {
                    foreach (string x in txtPersonajes.SelectedItems)
                    {
                        if (x == perosnaje_seleccionado._name)
                        {
                            Personaje Personaje_aux = new Personaje();
                            Personaje_aux._name = perosnaje_seleccionado._name.ToString();
                            Personaje_aux._identity = perosnaje_seleccionado._identity.ToString();
                            Personaje_aux._rol = perosnaje_seleccionado._rol.ToString();
                            Personaje_aux._age = perosnaje_seleccionado._age;
                            Personaje_aux._sex = perosnaje_seleccionado._sex.ToString();
                            Personaje_aux._activity = perosnaje_seleccionado._activity;
                            Personaje_aux._universe = perosnaje_seleccionado._universe.ToString();
                            Personaje_aux._img = perosnaje_seleccionado._img.ToString();

                            personajes_pelicula.Add(Personaje_aux);
                        }
                    }
                }
                foreach (string y in txtDirectores.SelectedItems)
                {
                    nombre_directores.Add(y.ToString());
                }
                var (validado, dialog) = validar_datos(txtNombre.Text, txtUniverso.Text, txtMonto.Value, nombre_directores.Count, personajes_pelicula.Count);

                if (validado)
                {
                    Movie_aux._name = txtNombre.Text.ToString();
                    Movie_aux._year = int.Parse(txtPresentacion.Text);
                    Movie_aux._amount = float.Parse(txtMonto.Text);
                    Movie_aux._universe = txtUniverso.Text.ToString();


                    Movie_aux._directors = nombre_directores;
                    Movie_aux._casting = personajes_pelicula;

                    pelis.movie_add(Movie_aux);
                    pelis.serealizar_pelicula();
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("No puedes ingresar la misma pelicula dos veces");
            }

            
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            txtDirectores.Items.Clear();
            List<string> Personajes = new List<string>();
            txtPersonajes.DataSource =null;
            if (buscar(txtBuscar.Text))
            {
                foreach (Movie aux in pelis.descerealizar_pelicula())
                {
                    if (aux._name == txtBuscar.Text)
                    {
                        txtNombre.Text = aux._name;
                        txtPresentacion.Value = Convert.ToDecimal(aux._year);
                        txtUniverso.Text = aux._universe;
                        txtMonto.Value = Convert.ToDecimal(aux._amount);
                        foreach (string director in aux._directors)
                        {
                            txtDirectores.Items.Add(director);
                        }

                        foreach (Personaje personajes_aux in aux._casting)
                        {
                            Personajes.Add(personajes_aux._name);
                        }
                        txtPersonajes.DataSource = Personajes;
                    }
                }
            }  
        }

        private (bool, DialogResult) validar_datos(string nombre, string universo, decimal monto, int directores, int personajes)
        {
            if (nombre == "") { return (false, MessageBox.Show("El nombre de la película no puede ir en blanco")); }
            if (universo == "") { return (false, MessageBox.Show("Ingrese el universo al cual pertenece la película")); }
            if (monto <= 0) { return (false, MessageBox.Show("El monto recaudado no puede ser igual a cero")); }
            if (directores <= 0) { return (false, MessageBox.Show("Por favor ingrese los directores de la película")); }  
            if (personajes <=0 ) { return (false, MessageBox.Show("Por favor ingrese los personajes de la película")); }
            else { return (true, MessageBox.Show("Datos almacenados en el archivo")); }
        }

        private bool buscar(string nombre_pelicula)
        {
            foreach (Movie aux in pelis.descerealizar_pelicula())
            {
                if (aux._name == nombre_pelicula)
                {
                    return true;
                }
            }
            return false;
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtMonto.Value = default;
            txtPersonajes.SelectedItem = default;
            txtDirectores.SelectedItem = default;
            txtUniverso.Text = default;
            txtPresentacion.Value = 1951;
        }
    }
}

