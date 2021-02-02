using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClasesUML
{
    class Staff : Person
    {
        private string School { get; set; }
        private double Pay { get; set; }
        public Staff(string Name, string Address, string School, double Pay): base(Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }

        public override string ToString()
        {
            string output = base.ToString();
            output += $"School: {School} \n";
            output += $"Pay: ${Pay} \n";
            return output;
        }
    }
}
