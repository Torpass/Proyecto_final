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
    public partial class visualizar_personajes : Form
    {
        static Lista_personajes personajes = new Lista_personajes();
        List<Personaje> personajes_agregados = personajes.personajes_desceralizados();

        List<Personaje> Personajes_hombre = new List<Personaje>();
        List<Personaje> Personajes_mujer = new List<Personaje>();
        List<Personaje> Personajes_desconocido = new List<Personaje>();
        List<Personaje> Personajes_alien = new List<Personaje>();


        List<Personaje> Personajes_heroe = new List<Personaje>();
        List<Personaje> Personajes_antiheroe = new List<Personaje>();
        List<Personaje> Personajes_villano = new List<Personaje>();

        string ruta_imagen = @".\data\imagenes\";

        public visualizar_personajes()
        {
            InitializeComponent();
            mostrar_gridview(personajes_agregados);
            sexo_persoanje();
            rol_persoanje();
        }


        private void txtUniverso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Edad") { ContenedorSexo.Visible = false; ContenedorRol.Visible = false; ContenedorEdades.Visible = true; }
            if (txtBuscar.Text == "Tipo de Personaje") { ContenedorEdades.Visible = false; ContenedorSexo.Visible = false; ContenedorRol.Visible = true; }
            if (txtBuscar.Text == "Sexo") { ContenedorRol.Visible = false; ContenedorEdades.Visible = false; ContenedorSexo.Visible = true; }
        }


        private void btnSexo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (btnSexo.Text == "Hombre") { mostrar_gridview(Personajes_hombre); }
            if (btnSexo.Text == "Mujer") { mostrar_gridview(Personajes_mujer); }
            if (btnSexo.Text == "Desconocido") { mostrar_gridview(Personajes_desconocido); }
            if (btnSexo.Text == "Alien") { mostrar_gridview(Personajes_alien); }
        }

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Personaje> rango = rango_edad(Convert.ToInt16(edad_1.Value), Convert.ToInt16(edad_2.Value));
            mostrar_gridview(rango);
        }


        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            mostrar_gridview(personajes_agregados);
        }


        public void sexo_persoanje()
        {
            foreach (Personaje x in personajes_agregados)
            {
                if (x._sex == "Hombre") { Personajes_hombre.Add(x); }
                if (x._sex == "Mujer") { Personajes_mujer.Add(x); }
                if (x._sex == "Desconocido") { Personajes_desconocido.Add(x); }
                if (x._sex == "Alien") { Personajes_alien.Add(x); }
            }
        }

        public void rol_persoanje()
        {
            foreach (Personaje x in personajes_agregados)
            {
                if (x._rol == "Heroe") { Personajes_heroe.Add(x); }
                if (x._rol == "Antiheroe") { Personajes_antiheroe.Add(x); }
                if (x._rol == "Villano") { Personajes_villano.Add(x); }
                
            }
        }


        public List<Personaje> rango_edad(int edad_1, int edad_2)
        {
            List<Personaje> Personaje_rango = new List<Personaje>();

            foreach (Personaje aux in personajes_agregados)
            {
                if (aux._age >= edad_1 && aux._age <= edad_2 || aux._age >= edad_2 && aux._age <= edad_1)
                {
                    Personaje_rango.Add(aux);
                }
            }
            return Personaje_rango;
        }





        public void mostrar_gridview(List<Personaje> mostrar)
        {
            DataGridView.Rows.Clear();
            DataGridView.RowTemplate.Height = 200;
            foreach (Personaje agregar in mostrar)
            {
                int rowindex = DataGridView.Rows.Add();
                DataGridView.Rows[rowindex].Cells[0].Value = agregar._name.ToString();
                DataGridView.Rows[rowindex].Cells[1].Value = agregar._identity.ToString();
                DataGridView.Rows[rowindex].Cells[2].Value = agregar._universe.ToString();
                DataGridView.Rows[rowindex].Cells[3].Value = agregar._rol.ToString();
                DataGridView.Rows[rowindex].Cells[4].Value = agregar._age.ToString();
                DataGridView.Rows[rowindex].Cells[5].Value = agregar._sex.ToString();
                try { DataGridView.Rows[rowindex].Cells[6].Value = Image.FromFile(ruta_imagen + agregar._img); }
                catch (Exception x) { DataGridView.Rows[rowindex].Cells[6].Value = null; }
            }
        }

        private void btnRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnRol.Text == "Heroe") { mostrar_gridview(Personajes_heroe); }
            if (btnRol.Text == "Antiheroe") { mostrar_gridview(Personajes_antiheroe); }
            if (btnRol.Text == "Villano") { mostrar_gridview(Personajes_villano); }
        }
    }
}
