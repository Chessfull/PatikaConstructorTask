using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaConstructorTask
{
    public class Baby
    {
        public DateTime birthDate { get; set; }
        public string name { get; set; }
        public string surName { get; set; }


        public Baby()
        {
            Console.WriteLine("Ingaaaa");
            this.birthDate = DateTime.Now;
        }
        public Baby(string name, string surName)
        {
            this.name = name;
            this.surName = surName;
            Console.WriteLine("Ingaaaa");
            this.birthDate = DateTime.Now;
        }

        public void Greeting()
        {
            Console.WriteLine($"Name: {this.name}\nSurname: {this.surName}\nBirthdate: {this.birthDate.ToString("dd.MM.yyyy")}\nCongratulations! You have baby!");
        }
    }
}
