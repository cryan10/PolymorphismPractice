using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    class ParentClass
    {
        // virtual only exists in parent class
        public virtual void Clean()
        {
            Console.WriteLine("Let's clean the kitchen");
        }

        public virtual void Cook()
        {
            Console.WriteLine("Let's cook some food");
        }

   
    }
}
