using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampCuric
{
    class Topic
    {
        private static int NextId { get; set; } = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Difficulty { get; set; }

        public Topic()
        {   //this. is not need but here just as an example. we only need this. when property and parameters are the same name.
            this.Id = NextId++;
            //NextId = NextId + 2;         //this line is for more than 1.
        }
        public void Print()
        {
            Console.WriteLine($"{Id} | {Name} | {Category} | {Difficulty}");
        }

    }
}
