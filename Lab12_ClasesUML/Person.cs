using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClasesUML
{
    class Person
    {
        private string Name { get; set; }
        private string Address { get; set; }

        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        public override string ToString()
        {
            string output = "";
            output += $"Name: {Name} \n";
            output += $"Address: {Address} \n";
            return output;
        }

        public virtual void AddPerson()
        {

        }
    }
}
