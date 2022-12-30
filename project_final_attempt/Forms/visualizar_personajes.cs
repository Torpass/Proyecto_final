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
        Lista_personajes personajes = new Lista_personajes();

        public visualizar_personajes()
        {
            InitializeComponent();
            List<Personaje> personajes_agregados = personajes.personajes_desceralizados();

            foreach (Personaje agregar in personajes_agregados)
            {
                int rowindex = DataGridView.Rows.Add();
                DataGridView.Rows[rowindex].Cells[0].Value = agregar._name.ToString();
                DataGridView.Rows[rowindex].Cells[1].Value = agregar._identity.ToString();
                DataGridView.Rows[rowindex].Cells[2].Value = agregar._universe.ToString();
                DataGridView.Rows[rowindex].Cells[3].Value = agregar._rol.ToString();
                DataGridView.Rows[rowindex].Cells[4].Value = agregar._age.ToString();
                DataGridView.Rows[rowindex].Cells[5].Value = agregar._sex.ToString();
            }

        }
    }
}
