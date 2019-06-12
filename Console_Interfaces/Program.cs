using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface IMyInterface           //Interface is a public class which all Interface's members aren't implemented !
    {
        // int MyField;              Error : Interfaces can not have fields
        int MyProperty { get; set; }  // Interfaces can have property
        void MyMethod();
    }


    interface IMyInterface2   //My second Interface
        {

        }

    class MyClass : IMyInterface  //Any class which Inherited from Interface should Implement Interface members.
    {
        public int MyProperty { get ; set ; }   //Interface's Property should re-define

        public void MyMethod()          
        {
            Console.WriteLine("I am Implemented method of the Interface");
        }
        
    }

    class MyClass2 : IMyInterface, IMyInterface2     // Interfaces able developer to do Multiple Inheritance
    {
        public int MyProperty { get; set; }

        public void MyMethod()
        {
            
        }
    }


}

/* 
Note:

1) Interface's member and Abstract-Class's member both of them doesn't have body and the class which inherited from them should implement those members;
2)Interface can have only (methods, properties, events or indexers-(NOT FIELD)) BUT Abstract accept all type of members (also Field)

*/
