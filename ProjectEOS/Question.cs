using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEOS
{
    internal class Question
    {

        public string SubjectID { get; set; }
        public string QuestionsID {get; set; }



        public string Questions { get; set; }

        public string AnswerA { get; set; }

        public string AnswerB { get; set; }

        public string AnswerC { get; set; }

        public string AnswerD { get; set; }

        public string AnswerRight { get; set; }

        public Question(string subjectID, string questionsID, string questions, string answerA, string answerB, string answerC, string answerD, string answerRight)
        {
            SubjectID = subjectID;
            QuestionsID = questionsID;

            Questions = questions;
            AnswerA = answerA;
            AnswerB = answerB;
            AnswerC = answerC;
            AnswerD = answerD;
            AnswerRight = answerRight;
        }
    }
}
