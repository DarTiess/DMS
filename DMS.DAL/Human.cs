using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.DAL
{
    public enum Gender
    {
        male,
        female,
        none
    }
    [Serializable]
    public abstract class Human
    {
        public Human() : this(0," ",Gender.none)
            {

        }
        public Human(int Id, string Name, Gender gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.gender = gender;
        }
        public int Id { get;  set; }
        public string Name { get;  set; }
        public Gender gender;
        public DateTime BirthDay { get;  set; }
        public int Age { get { return (DateTime.Now.Year - BirthDay.Year); } }
    }
}
