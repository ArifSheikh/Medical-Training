using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Medical_Training_Center
{
    static class GlobalData
    {
        private static DataTable QuestionData;
        private static int QuestionID;

        public static DataTable dtQuestionData
        {
            get
            {
                return QuestionData;
            }
            set
            {
                QuestionData = value;
            }
        }

        public static int CurrentQuestionID
        {
            get
            {
                return QuestionID;
            }
            set
            {
                QuestionID = value;
            }
        }
    }
}
