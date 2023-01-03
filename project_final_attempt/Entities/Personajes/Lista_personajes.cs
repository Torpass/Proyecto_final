using project_final_attempt.Forms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace project_final_attempt.Entities.Personajes
{
    internal class Lista_personajes
    {
        private String ruta = @".\data\DatosPersonaje.txt";
        private String ruta_imagenes = @".\data\imagenes\";
        private List<Personaje> heroes;


        public Lista_personajes()
        {
            heroes = new List<Personaje>();
        }



        //Añada un nuevo Personaje a la lista 
        public void heroe_create(Personaje x)
        {
            heroes.Add(x);
        }


        public Personaje buscar(string nombre_personaje)
        {
           List<Personaje> Persoanjes = personajes_desceralizados();
            Personaje Persona_encontrado = new Personaje();

            foreach (Personaje aux in Persoanjes)
            {
                if (aux._name == nombre_personaje)
                {
                    Persona_encontrado._name = aux._name;
                    Persona_encontrado._rol = aux._rol;
                    Persona_encontrado._identity = aux._identity;
                    Persona_encontrado._activity = aux._activity;
                    Persona_encontrado._age = aux._age;
                    Persona_encontrado._img = aux._img;
                    Persona_encontrado._sex = aux._sex;
                    Persona_encontrado._universe = aux._universe;  
                    Persona_encontrado._id = aux._id;
                    return Persona_encontrado;
                }
            }
            return null;
        }


        public void eliminar(string eliminar_personaje)
        {
            heroes = personajes_desceralizados();
            foreach (Personaje aux in heroes)
            {
                if (aux._name == eliminar_personaje)
                {
                    heroes.Remove(aux);
                    break;
                }
            }
            File.Delete(ruta);
            serealizar_personaje();
        }


        public void garbage_colector()
        {
            try
            {
                string[] ficheros = Directory.GetFiles(ruta_imagenes);
                string[] nombres = new string[0];
                List<string> list_nombres = new List<string>(nombres.ToList());
                List<Personaje> garbaje = personajes_desceralizados();

                foreach (Personaje x in garbaje)
                {
                    list_nombres.Add(x._img);
                }
                for (int i = 0; i < ficheros.Length; i++)
                {
                    ficheros[i] = ficheros[i].Replace(ruta_imagenes, "");
                }

                IEnumerable<string> eliminar = ficheros.Except(list_nombres);

                if (eliminar.Count() >= 1)
                {
                    foreach (string x in eliminar)
                    {
                        File.Delete(ruta_imagenes + x);
                    }
                }

            }
            catch (Exception x)
            {
               
            }
        }


        //El objeto de tipo Personaje enviado por el form, lo recibe y lo convierte en un string para ser guardado en un archivo de texto
        public void serealizar_personaje()
        {
            FileStream metodo = new FileStream(ruta, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(metodo);

            foreach (Personaje aux in heroes)
            {
                writer.WriteLine(leerPersonaje(aux));
            }
            heroes.Clear();
            writer.Close();
        }

        //El objeto enviado por el formulario, lo serializa, separado cada elemento en orden por un '|'
        private string leerPersonaje(Personaje aux)
        {
            string cadena = String.Empty;
            string separador = '|'.ToString().Trim();

            cadena = aux._name.ToString()
                   + separador + aux._age.ToString()
                   + separador + aux._identity.ToString()
                   + separador + aux._rol.ToString()
                   + separador + aux._sex.ToString()
                   + separador + aux._universe.ToString()
                   + separador + aux._activity.ToString()
                   + separador + aux._img.ToString()
                   + separador + aux._id.ToString();
            return cadena;
        }


        //Agarra el string enviado por el redline y lo convierte en un objeto de tipo "Personaje" para ser agregado a la lista
        public List<Personaje> personajes_desceralizados()
        {
            List<Personaje> desceralizados = new List<Personaje>();
            FileStream acceso = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(acceso);

            string linea = lector.ReadLine();
            if (linea != "")
            {
                while (linea != null)
                {
                    desceralizados.Add(Leer(linea));
                    linea = lector.ReadLine();
                }
                lector.Close();
            }
            lector.Close();
            return desceralizados;
        }


        //La linea leida por el ReadLine la separa por '|' y los guarda en un arreglo, donde cada posición va a ser un dato del personaje
        private Personaje Leer(string cadena_personaje)
        {
            Personaje aux = new Personaje();
            string[] arreglo_personaje = cadena_personaje.Split('|');

            aux._name = Convert.ToString(arreglo_personaje[0]);
            aux._age = Convert.ToInt16(arreglo_personaje[1]);
            aux._identity = Convert.ToString(arreglo_personaje[2]);
            aux._rol = Convert.ToString(arreglo_personaje[3]);
            aux._sex = Convert.ToString(arreglo_personaje[4]);
            aux._universe = Convert.ToString(arreglo_personaje[5]);
            aux._activity = Convert.ToBoolean(arreglo_personaje[6]);
            aux._img = Convert.ToString(arreglo_personaje[7]);
            aux._id = Convert.ToString(arreglo_personaje[8]);
            return aux;
        }

    }


}
