using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DMS.DAL
{
    public delegate void sentMessage( string message);

    public class AssemblyLaboratory
    {
       private sentMessage sm;
        public void RegistrDelegate(sentMessage del)
        {
            sm = del;
        }
        public void CreateLaboratory(Laboratory lab)
        {

            
            XmlSerializer formatter =
                 new XmlSerializer(typeof(Laboratory));
            using (FileStream fs = 
                new FileStream("lab_" + lab.LabId + ".xml", FileMode.OpenOrCreate))
            {
                try { 
                formatter.Serialize(fs, lab);
                    sm.Invoke("Лаборатория успешно создана");
                }
                catch (Exception ex)
                {
                    sm.Invoke(ex.Message);
                }
            }
           

        }

        public string WorkersUrl { get
            {
                var workUrl = ConfigurationManager.GetSection("Path") as NameValueCollection;
                return workUrl["WorkersUrl"];
            } }
        private List<Laborant> GetWorkers()
        {
            List<Laborant> labory = null;
            XmlSerializer formatter=new XmlSerializer(typeof(Laborant[]));
            using(FileStream fs=new FileStream(WorkersUrl+@"\Labworkers.xml", FileMode.OpenOrCreate))
            {
                try
                {
                    labory = ((Laborant[])formatter.Deserialize(fs)).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return labory;
        }

        public void CreateLabWorkers(Laborant lb)
        {
           List<Laborant> lbs= GetWorkers();
            if (lbs == null)
            {
                lbs = new List<Laborant>();
            }
            lbs.Add(lb);
            XmlSerializer formatter = new XmlSerializer(typeof(Laborant[]));
            using (FileStream fs = new FileStream(WorkersUrl+ @"\Labworkers.xml", FileMode.OpenOrCreate))
            {
                try
                {
                    formatter.Serialize(fs, lbs.ToArray());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        public Laborant LogOn(string Login, string Password)
        {
            Laborant lb = null;
            List<Laborant> lbs = GetWorkers();
            if (lbs != null)
            {
                lb = lbs.FirstOrDefault(w => w.LogIn == Login && w.Password == Password);
            }
            
            return lb;
        }
    }
}
