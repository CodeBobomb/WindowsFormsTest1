using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public User()
        {
            Name = "ime";
            Surname = "prezime";
        }
        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
