using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        /*This is the constructor which is a special method
        that gets invoked when instantiating a new instance of class.*/
        public Car()
        {
 
        }
        //Create a Make property of type string that is public
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

    }
}
