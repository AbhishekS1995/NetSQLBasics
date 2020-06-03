using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TrainingConsole
{
    public class Person
    {
        public int PersonalID
        {
            get
            {
                return _autoIncrementValue;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Discriminator { get; set; }

        static int nextId;
        private int _autoIncrementValue;
        public Person()
        {
            _autoIncrementValue = Interlocked.Increment(ref nextId);
        }
        public void Print()
        {
           
            Console.WriteLine("Hello {0}!",FirstName);
            Console.WriteLine("{0} {1} {2} is a {3}", PersonalID, FirstName,LastName,Discriminator);
        }
    }
}