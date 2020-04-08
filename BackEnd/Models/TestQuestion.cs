using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace BackEnd.Models
{
    public class TestQuestion
    {
        public int TestQuestionID { get; set; }
        public int TestID { get; set; }
        public int QuestionID { get; set; }
        public Question Question { get; set; }
        public Test Test { get; set; }
        public override string ToString() => JsonSerializer.Serialize<TestQuestion>(this);
    }
}
