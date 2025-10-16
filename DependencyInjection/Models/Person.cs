using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class Person
    {
        private Home _home;

        //  private School _school;//so i want to make the school also change to college university etc so use interface 
        private IEducationalInstitutions _school;
        // private Hospital _hospital;//now do not need because method injection

        //property injection
        public IEducationalInstitutions School
        {
            set { _school = value; }
        }
        public Person(Home home) //dependency injection
        {
            _home = home;
           // _school=new School();
          //  _hospital=new Hospital();

        }
        public void TakeRefuge()
        {
            _home.ProvideShelter(this);
            
        }
        public void Study()
        {
            _school.Teach(this);
        }

        //public void GetTreatment()
        //{
        //    _hospital.Cure(this);
        //}
        public void GetTreatment(Hospital hospital)
        {
            hospital.Cure(this);
        }


    }
}
