using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace countinue_of_the_course_16

{
   
    class Program
    {
  /*    public  class Personne
        {
            public virtual void Greet()
            {
                Console.WriteLine("The Personne say Hello");

            }
            public virtual void  SayGoodBay()
            {
                Console.WriteLine(" the Personne say Good Bay");
            }
        }
        public class Employee : Personne
        {
            public sealed override void Greet()
            {
                Console.WriteLine("the Employee say Hello");
            }
            public new  void SayGoodBay()
            {
                Console.WriteLine(" the Employee say Good Bay");
            }
        }
        public class Mnager : Employee
        {
            
        }*/
        static void Main(string[] args)
        {
            /*   Personne personne = new Personne();
                 personne.Greet();
                 Employee employee = new Employee();
                 employee.Greet();
                 Personne personne2 = new Employee();
                 personne2.SayGoodBay();
                 Mnager mnager = new Mnager();
                 mnager.Greet();
                  MyClass myClass = new MyClass();
                 myClass.Methode1();
                 myClass.Methode2();*/

            Personne personne = new Personne();
            personne.Age = 25;
            personne.britheDate();
        }
    }
}
