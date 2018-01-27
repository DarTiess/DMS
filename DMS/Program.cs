using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMS.DAL;
using GeneratorName;

namespace DMS
{
    class Program
    {
        
        static void Main(string[] args)
        {
            AssemblyLaboratory al = new AssemblyLaboratory();
            //Laborant lb = new Laborant(2, "John", DAL.Gender.male);
            //lb.BirthDay = DateTime.Now.AddMonths(-250);
            //lb.LogIn = "lab2";
            //lb.Password = "s541521";

            //al.CreateLabWorkers(lb);
            Laborant lb=
            al.LogOn(Console.ReadLine(),Console.ReadLine());
            if (lb != null)
                Console.WriteLine("Hi " + lb.Name);
            else
                Console.WriteLine("Access denied");

            //DGenerate del = sentMsg;
            //Generator g = new Generator();
            //g.RegisterHedler(del);
            //g.Generate(Gender.man);

            //sentMessage sm = sentMsg;
            
            //AssemblyLaboratory al = new AssemblyLaboratory();
            //al.RegistrDelegate(sm);
            //Laboratory lab = new Laboratory();
            //lab.Adress = "Adress";
            //lab.LabId = 1;
          
            //lab.PhoneNumber = "8777 77 77 000";
            //al.CreateLaboratory(lab);

        }
        //static void sentMsg(string message)
        //{
        //    Console.WriteLine(message);
        //}
    }
}
