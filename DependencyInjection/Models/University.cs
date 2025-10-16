using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class University : IEducationalInstitutions
    {
        public void Teach(Person person)
        {
            Console.WriteLine("Educate person in University");
        }
    }
}
