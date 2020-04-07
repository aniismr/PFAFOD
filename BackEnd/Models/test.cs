using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using BackEnd.Data;
using System.Linq;
using System;
namespace BackEnd.Models
{
    public class Test
    {
        public int TestId { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Date { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public int NbCandidature { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        
        public string Heure { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        
        public ICollection<TestCandidature> TestCandidature { get; set; }
        public ICollection<TestCategorie> TestCategorie { get; set; }
        public int NbPlace {get;set;}
        public string Type{get;set;}
        public override string ToString() => JsonSerializer.Serialize<Test>(this);

    }
}
