using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2016_summer
{
    /**
     * This class is the "driver" class for our program
     * 
     * @class Program
     * */
    public class Program
    {

        /**
         * the main method for out driver class
         * 
         * @method Main
         * @param {string[]} args
         * */
        public static void Main(string[] args)
        {
           

            Person shav = new Person("shav", 24);
            Person Rohan = new Person("Rohan", 21);
            //say hello and show age 
            shav.ShowAge();
            Rohan.ShowAge();
            shav.SayHello();
            Rohan.ShowAge();
        }
    }
}