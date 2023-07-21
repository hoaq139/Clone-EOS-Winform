using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEOS
{
    internal class StudentChoice
    {
        public string? QuestionID { get; set; }

        public string? choice { get; set; }

        public StudentChoice(string? questionID, string? choice)
        {
            QuestionID = questionID;
            this.choice = choice;
        }
    }
}
