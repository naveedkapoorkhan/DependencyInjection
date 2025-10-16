using DependencyInjection.Models;

namespace DependencyInjection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Home home = new Home();
            Person person = new Person(home);
          //  person.GetTreatment();
           
            person.TakeRefuge();
            person.School=new University();//property injection
           
            person.Study();

             Hospital hospital = new Hospital();//this way
            person.GetTreatment(hospital);//this waay
            person.GetTreatment(new Hospital());//second way
            person.School = new School();//property injection

            person.Study();

        }
    }
}