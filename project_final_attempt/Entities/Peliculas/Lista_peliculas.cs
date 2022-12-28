using project_final_attempt.Entities.Personajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace project_final_attempt.Entities.Peliculas
{
    public class Lista_peliculas
    {
        private String ruta = @".\data\DatosPeliculas.txt";
        private List<Movie> movies;

        public Lista_peliculas()
        {
            movies = new List<Movie>();
        }

        public void movie_add(Movie movie)
        {
            movies.Add(movie);
        }

        
        public void serealizar_pelicula()
        {
            FileStream metodo = new FileStream(ruta, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(metodo);

            foreach (Movie aux in movies)
            {
                writer.WriteLine(write(aux));
            }
            movies.Clear();
            writer.Close();
        }


        public void eliminar(string eliminar_personaje)
        {
            movies = descerealizar_pelicula();
            foreach (Movie aux in movies)
            {
                if (aux._name == eliminar_personaje)
                {
                    movies.Remove(aux);
                    break;
                }
            }

            File.Delete(ruta);
            serealizar_pelicula();
        }




        private string write(Movie movie)
        {
            string etique_apertura = "<p>";
            string etique_cierre = "</p>";
            string cadena_pelicula = string.Empty;
            string cadena_directores = string.Empty;
            string cadena_personaje = string.Empty;

            foreach (Personaje aux in movie._casting)
            {
                cadena_personaje += leerPersonaje(aux);
            }


            cadena_directores = leerDirectores(movie._directors);


            cadena_pelicula =
                 etique_apertura + movie._name.ToString().Trim() + etique_cierre +
                 etique_apertura + movie._year.ToString().Trim() + etique_cierre +
                 cadena_directores +
                 etique_apertura + movie._amount.ToString().Trim() + etique_cierre +
                 etique_apertura + movie._universe.ToString().Trim() + etique_cierre +
                 cadena_personaje;

            return cadena_pelicula;
        }


        private string leerDirectores(List<string> directores)
        {
            string cadena_directores = string.Empty;
            string etique_apertura = "<d>";
            string etique_cierre = "</d>";
            string seprador = "|".ToString().Trim();

            foreach (string director in directores)
            {
                cadena_directores += director + seprador;
            }
            cadena_directores = etique_apertura + cadena_directores + etique_cierre;

            return cadena_directores;
        }

        private string leerPersonaje(Personaje aux)
        {
            string etique_apertura = "<c>";
            string etique_cierre = "</c>";
            string seprador = "|".ToString().Trim();
            string cadena = String.Empty;

            cadena = etique_apertura + aux._name.ToString().Trim() + seprador +
                     aux._age.ToString().Trim() + seprador +
                     aux._identity.ToString().Trim() + seprador +
                     aux._rol.ToString().Trim() + seprador +
                     aux._sex.ToString().Trim() + seprador +
                     aux._universe.ToString().Trim() + seprador +
                     aux._activity.ToString().Trim() + seprador +
                     aux._img.ToString().Trim() + etique_cierre;
            return cadena;
        }


        public List<Movie> descerealizar_pelicula()
        {
            List<Movie> peliculas_descerealizadas = new List<Movie>();
            FileStream acceso = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader lector = new StreamReader(acceso);
            string cadena = lector.ReadLine();
            while (cadena != null)
            {
                peliculas_descerealizadas.Add(leer_pelicula(cadena));
                cadena = lector.ReadLine();
            }
            lector.Close();
            return peliculas_descerealizadas;
        }

        private Movie leer_pelicula(string cadena_movie)
        {
            List<Personaje> personajes_aux = new List<Personaje>();
            Movie movie_aux = new Movie();

            Regex datos = new Regex(@"<p>.*?</p>");
            Regex directores = new Regex(@"<d>.*?</d>");
            Regex personajes = new Regex(@"<c>.*?</c>");

            MatchCollection match_datos = datos.Matches(cadena_movie);
            MatchCollection match_directores = directores.Matches(cadena_movie);
            MatchCollection match_personajes = personajes.Matches(cadena_movie);

            List<string> datos_match = new List<string>();
            List<string> directores_match = new List<string>();
            List<string> personajes_match = new List<string>();

            for (int i = 0; i < match_datos.Count; i++)
            {
                datos_match.Add(match_datos[i].ToString());
            }
            for (int i = 0; i < match_datos.Count; i++)
            {
                datos_match[i] = datos_match[i].ToString().Replace("<p>", "").Replace("</p>", "");
            }
            movie_aux._name = datos_match[0];
            movie_aux._year = int.Parse(datos_match[1]);
            movie_aux._amount = int.Parse(datos_match[2]);
            movie_aux._universe = datos_match[3];

            directores_match.Add(match_directores[0].ToString());
            directores_match[0] = directores_match[0].ToString().Replace("<d>", "").Replace("</d>", "");
            movie_aux._directors = leer_directores(directores_match[0]);


            for (int i = 0; i < match_personajes.Count; i++)
            {
                personajes_match.Add(match_personajes[i].ToString());
            }
            for (int i = 0; i < personajes_match.Count; i++)
            {
                personajes_match[i] = personajes_match[i].ToString().Replace("<c>", "").Replace("</c>", "");
            }
            foreach (string pelicula in personajes_match)
            {
                personajes_aux.Add(leer_personajes(pelicula));
            }
            movie_aux._casting = personajes_aux;

            return movie_aux;
        }

        private Personaje leer_personajes(string cadena_personaje)
        {
            Personaje aux = new Personaje();
            String[] arreglo_personaje = cadena_personaje.Split('|');
            aux._name = Convert.ToString(arreglo_personaje[0]);
            aux._age = Convert.ToInt16(arreglo_personaje[1]);
            aux._identity = Convert.ToString(arreglo_personaje[2]);
            aux._rol = Convert.ToString(arreglo_personaje[3]);
            aux._sex = Convert.ToString(arreglo_personaje[4]);
            aux._universe = Convert.ToString(arreglo_personaje[5]);
            aux._activity = Convert.ToBoolean(arreglo_personaje[6]);
            aux._img = Convert.ToString(arreglo_personaje[7]);
            return aux;
        }


        private List<string> leer_directores(string cadena_directores)
        {
            List<string> director = new List<string>();

            string[] directores = cadena_directores.Split('|');

            for (int i = 0; i < directores.Length; i++)
            {
                director.Add(Convert.ToString(directores[i]));
            }

            return director;
        }


    }
}
