using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Medical_Training_Center
{
    class QuestionVO
    {
        private int ID;
        private string Type;
        private string Title;
        private string[] Question;
        private string[] Options;
        private string[] Answer;

        public int QuestionID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string QuestionType
        {
            get { return Type; }
            set { Type = value; }
        }

        public string QuestionTitle
        {
            get { return Title; }
            set { Title = value; }
        }

        public string[] QuestionName
        {
            get { return Question; }
            set { Question = value; }
        }
        
        public string[] QuestionOptions
        {
            get { return Options; }
            set { Options = value; }
        }

        public string[] QuestionAnswer
        {
            get { return Answer; }
            set { Answer = value; }
        }
    }
}
