using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsole
{
    public class Technology
    {
        private int technologyID;
        private string technologyName;

        public int TechnologyID
        {
            get
            {
                return technologyID;
            }
            private set
            {
                technologyID = value;
            }
        }

        public string TechnologyName
        {
            get
            {
                return technologyName;
            }
            private set
            {
                technologyName = value;
            }
        }

        public void Print()
        {
            TechnologyID = 1;
            TechnologyName = "Asp.Net";

            Console.WriteLine("The ID of {0} is {1}", TechnologyName, TechnologyID);
            Console.ReadKey();
        }
    }
}
