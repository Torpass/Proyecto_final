using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_final_attempt.Entities.Personajes
{
    public class Personaje
    {
        private string name;
        private string sex;
        private int age;
        private string rol;
        private string identity;
        private string universe;
        private bool activity;
        private string ID;
        private string img;


        public string _name { get { return name; } set { name = value; } }
        public string _sex { get { return sex; } set { sex = value; } }
        public int _age { get { return age; } set { age = value; } }
        public string _rol { get { return rol; } set { rol = value; } }
        public string _identity { get { return identity; } set { identity = value; } }
        public string _universe { get { return universe; } set { universe = value; } }
        public bool _activity { get { return activity; } set { activity = value; } }
        public string _img { get { return img; } set { img = value; } }
        public string _id { get { return ID; } set { ID = value; } }


        public Personaje()
        {
            _name = null;
            _sex = null;
            _age = 0;
            _rol = null;
            _identity = null;
            _universe = null;
            _activity = false;
            _img = null;
            _id = null;
        }
    }
}
