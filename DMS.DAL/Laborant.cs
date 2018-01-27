using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.DAL
{
    [Serializable]
   public class Laborant:Human
    {
        public Laborant() : this(0," ",Gender.none)
            {

        }
        public Laborant(int Id, string Name, Gender gender):base(Id,Name,gender)
        {

        }
        public string LogIn { set; get; }
        public string Password { get; set; }
        public Laboratory Place { get; set; }


    }
}
