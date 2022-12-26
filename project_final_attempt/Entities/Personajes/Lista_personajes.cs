﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_final_attempt.Entities.Personajes
{
    internal class Lista_personajes
    {
        private string separador = "\n";
        private String _h = "\r\n";
        private String ruta = @".\data\DatosPersonaje.txt";
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
                   + separador + aux._img.ToString();
            return cadena;
        }

        //Agarra el string enviado por el redline y lo convierte en un objeto de tipo "Personaje" para ser agregado a la lista
        public List<Personaje> personajes_desceralizados()
        {
            List<Personaje> desceralizados = new List<Personaje>();
            FileStream acceso = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader lector = new StreamReader(acceso);

            string linea = lector.ReadLine();
            while (linea != null)
            {
                desceralizados.Add(Leer(linea));
                linea = lector.ReadLine();
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
            return aux;
        }

    }
}