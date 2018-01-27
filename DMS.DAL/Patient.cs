using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.DAL
{
 
   public class Patient:Human
    {
        public Patient() : this(0," ",Gender.none)
            {

        }
        public Patient(int Id, string Name, Gender gender):base(Id,Name,gender)
        {
           
        }
       
        private string IIN_;
        public string IIn {
            get { return IIN_; }
            set {
                if (IIn.Length != 12)
                    Console.WriteLine("Введите корректный ИИН");
                else IIN_ = value;
            } }
       
        public List<Analysys> Analisiz { get; private set; } = new List<Analysys>();
        public string PhoneNumber { get; private set; }
        
        

    }
}
