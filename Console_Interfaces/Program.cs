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
        int MyProperty { get; set;  // Interfaces can have property
        void MyMethod();
    }

    class MyClass : IMyInterface   //Any class which Inherited from Interface should Implement Interface members.
    {
        public int MyProperty { get ; set ; }   //Interface's Property should re-define

        public void MyMethod()          
        {
            Console.WriteLine("I am Implemented method of the Interface");
        }
    }
}
