using System;
using System.Collections.Generic;

namespace Lab12UML
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ronald Golfly", "264 Lambchop Rd", "Electrical Engineering", 3, 145.67);
            Student student2 = new Student("Stanley Tungsten", "313 Offhand Dr", "Architecture", 4, 368.44);
            Student student3 = new Student("Grace Haberdashery", "825 Walnut Ct", "Theatre", 2, 586.29);
            Staff staff1 = new Staff("Phillipus Oswald", "611 Growley Ln", "Medicine", 52.37);
            Staff staff2 = new Staff("Esther Norwall", "103 Gladstone Pkwy", "Information", 65.91);

            List<Person> personList = new List<Person>
            {
                student1, student2, student3, staff1, staff2
            };

            foreach(Person person in personList)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
