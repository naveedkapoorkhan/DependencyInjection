using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class Hospital
    {
        
        internal void Cure(Person person)
        {
            Console.WriteLine("cure person");

        }
    }
}
