using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMe> data = new List<IMe>();
            InfoData dt = new InfoData();
            dt.FirstName = "A";
            dt.LastName = "B";

	        data.Add((IMe)(dt));
            
	        Source listOfSourses = new Source();
	        listOfSourses.CheckAndProceed(data);
        }

        interface IMe
        {
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class InfoData : IMe
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Source
        {
            internal void CheckAndProceed(List<IMe> data)
            {
                var dest = new Destination();

                //do something

                dest.ProceedData(data);
            }
        }

        class Destination
        {
            internal void ProceedData(List<IMe> data)
            {
                foreach (var item in data)
                {
                    //do something
                }
            }
        }





    }
}
