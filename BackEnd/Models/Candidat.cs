using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using BackEnd.Data;
using System.Linq;
using System;
namespace BackEnd.Models
{
    public class Candidat
{

        public int CandidatId { get; set; }
        [Column(TypeName ="nvarchar(20)")]
        public string Photo { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string CandidatNom { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string CandidatPrenom { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public int Experience { get; set; }
        public string DateDeNaissance{ get; set; }
        public ICollection<Candidature> Candidatures {get ;set;}
        public override string ToString() => JsonSerializer.Serialize<Candidat>(this);
}
}