using project_final_attempt.Entities.Personajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_final_attempt.Entities.Peliculas
{
    public class Movie
    {
        private string nombre_pelicula;
        private int? Ano_presentacion;
        private List<string> directores;
        private int? monto_recaudado;
        private string universo_perteneciente;
        private List<Personaje> personajes_pelicula;

        public string _name { get { return nombre_pelicula; } set { nombre_pelicula = value; } }
        public int? _year { get { return Ano_presentacion; } set { Ano_presentacion = value; } }
        public List<string> _directors { get { return directores; } set { directores = value; } }
        public int? _amount { get { return monto_recaudado; } set { monto_recaudado = value; } }
        public string _universe { get { return universo_perteneciente; } set { universo_perteneciente = value; } }
        public List<Personaje> _casting { get { return personajes_pelicula; } set { personajes_pelicula = value; } }

        public Movie(string name, int? year, List<string> directors_, int? amount, string universe, List<Personaje> casting)
        {
            _name = name;
            _year = year;
            _directors = directors_;
            _amount = amount;
            _universe = universe;
            _casting = casting;
        }

        public Movie()
        {
            _name = null;
            _year = null;
            _directors = null;
            _amount = null;
            _universe = null;
            _casting = null;
        }
    }
}
