using System;

namespace BootCampCuric
{
    class Program
    {
        static void Main(string[] args)
        {
            var gitgithub = new Topic();
            gitgithub.Name = "Git/GitHub";
            gitgithub.Category = "SCM";
            gitgithub.Difficulty = 2;
            var sql = new Topic()
            {
                Name = "SQL",
                Category = "Data Management",
                Difficulty = 1
            };
            var csharp = new Topic()
            {
                Name = "csharp",
                Category = "Encapsalation and interaction",
                Difficulty = 3
            };
            var java = new Topic()
            {
                Name = "Java",
                Category = "For C#",
                Difficulty = 2
            };
            gitgithub.Print();
            sql.Print();
            csharp.Print();
            java.Print();
            
            
        
                
        
            
        }
    }
}
