using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class College : IEducationalInstitutions
    {
        public void Teach(Person person)
        {
            Console.WriteLine("Educate Person in college");
        }
    }
}
