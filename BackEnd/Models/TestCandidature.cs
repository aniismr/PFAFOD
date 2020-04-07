using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
namespace BackEnd.Models
{
    public class TestCandidature
    {
        public int TestCandidatureID { get; set; }
        public int TestID { get; set; }
        public int CandidatureID { get; set; }
        public Candidature Candidature { get; set; }
        public Test Test { get; set; }
        
        public int Score { get; set; }
        public override string ToString() => JsonSerializer.Serialize<TestCandidature>(this);
        public TestCandidature(int CandidatureID){
                this.CandidatureID=CandidatureID;
        }
    }
    
}
