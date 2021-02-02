using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClasesUML
{
    class Student : Person
    {
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }
        public Student(string Name, string Address, string Program, int Year, double Fee):base(Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }

        public override string ToString()
        {
            string output = base.ToString();
            output += $"Program: {Program} \n";
            output += $"Year: {Year} \n";
            output += $"Fee: ${Fee} \n";
            return output;
        }
    }
}
