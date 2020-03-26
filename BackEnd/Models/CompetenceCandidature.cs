using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace BackEnd.Models
{
    public class CompetenceCandidature
{
        public int CompetenceCandidatureID { get; set; }
        public int CandidatureID { get; set; }
        public int CompetenceID { get; set; }
        public Competence Competence {get;set;}
        public Candidature Candidature {get;set;}
        public override string ToString() => JsonSerializer.Serialize<CompetenceCandidature>(this);
}
}