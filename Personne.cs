using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countinue_of_the_course_16
{
  public partial  class Personne
    {
        public int Age { get; set; }
         partial void printAge();
        public void britheDate()
        {
            Age++;
            printAge();
        }
    }
}
