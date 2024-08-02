using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaConstructorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ▼ Creating instance of baby object with 'parameters' constructor 2. ▼
            Baby babyMert=new Baby("Mert","Topcu");
            // ▼ Printing informations of baby ▼
            babyMert.Greeting();

            // ▼ Creating instance of baby object with default constructor 1. ▼
            Baby babyDefault = new Baby();
            babyDefault.name = "Ahmet";
            babyDefault.surName = "Mehmet";
            // ▼ Printing informations of baby ▼
            babyDefault.Greeting();
        }
    }
}
