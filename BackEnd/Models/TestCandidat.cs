using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
namespace BackEnd.Models
{
    public class TestCandidat
    {
        public int TestCandidatID { get; set; }
        public int TestID { get; set; }
        public int CandidatureID { get; set; }
        public Candidature Candidature { get; set; }
        public test Test { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string score { get; set; }
        public override string ToString() => JsonSerializer.Serialize<TestCandidat>(this);

    }
}
