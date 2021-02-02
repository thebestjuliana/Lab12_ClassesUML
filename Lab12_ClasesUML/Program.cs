using System;
using System.Collections.Generic;

namespace Lab12_ClasesUML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> schoolPeeps = new List<Person>();
            Student s1 = new Student("Oscar", "123 Hardknox Rd", "Physics", 2, 50000);
            Student s2 = new Student("George", "583 Marigold Ln", "Art", 10, 1000000000);
            Student s3 = new Student("Charlie", "9 Singleton Crecent", "Cullinary Arts", 3, 10000);
            Staff s4 = new Staff("Lucy", "793 Churchill St.", "Stephens University", 48000);
            Staff s5 = new Staff("Camille", "348 Bumblebee Dr", "Wayne State University", 90000);

            schoolPeeps.Add(s1);
            schoolPeeps.Add(s2);
            schoolPeeps.Add(s3);
            schoolPeeps.Add(s4);
            schoolPeeps.Add(s5);

            foreach (Person person in schoolPeeps)
            {
                Console.WriteLine(person.ToString());

            }

        }
    }
}
