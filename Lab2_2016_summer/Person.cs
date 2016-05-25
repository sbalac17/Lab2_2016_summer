using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2016_summer
{
    /**
     * This class describes a person
     * 
     * @class Person
     * */
    class Person
    {
        // instance variables (a class is anything.. )
        private string _name;
        private int _age;
        // this is a property (below)
        public string Name // able to view things that are private (above)  
        {
            get { return _name; }
        }

        /**
         * the constructor for a person
         * 
         * @method Person
         * @param {string} name
         * @param {int} age
         * */
        public Person(string name, int age) // this is a constructor to make a new person (so for new on the program page
            //this part will be called. 
        {
            _name = name;
            _age = age;
        }
        /**
         * this displays a hello message from the person
         * 
         * @method SayHello
         * */
        public void SayHello()
        {
            Console.WriteLine("{0} says hello", _name);
        }
        /**
         * this displays name and age of the person
         * 
         * @method ShowAge
         * */
        public void ShowAge()
        {
            Console.WriteLine("{0} is {1} years old", _name, _age);
        }

    }
}
