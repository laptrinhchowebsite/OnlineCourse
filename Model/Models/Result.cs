using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Result
    {
        public long UserID { get; set; }
        public long ExamID { get; set; }
        public string ResultQuiz { get; set; }
        public string ResultEssay { get; set; }
        public string StartDateQuiz { get; set; }
        public string StartTimeQuiz { get; set; }
        public string FinishTimeQuiz { get; set; }
        public Nullable<System.DateTime> StartDateEssay { get; set; }
        public string StartTimeEssay { get; set; }
        public string FinishTimeEssay { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Score { get; set; }
    }
}
