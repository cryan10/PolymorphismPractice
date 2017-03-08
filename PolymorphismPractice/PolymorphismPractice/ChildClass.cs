using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice
{
    class ChildClass : ParentClass
    {
        //override can only used in child classes; it allows for specific instructions 
        public override void Clean()
        {
            base.Clean(); //calls method from parent class
            //then add code to override parent class
        }

        public override void Cook()
        {
            base.Cook();
        }

    }
}
