using System.Collections.Generic;
using System.Text.Json;

namespace BackEnd.Models
{
    public class Candidature
{
    public int CandidatureID { get; set; }
    public string DatePostulation { get; set; }
    public string Type { get; set; }
    public int CandidatID{get;set;}
    public Candidat Candidat { get; set; }
    public ICollection<CompetenceCandidature> CompetenceCandidature { get; set; }
    public string CV { get; set; }
    public string Reponse { get; set; }
    public override string ToString() => JsonSerializer.Serialize<Candidature>(this);

}

}