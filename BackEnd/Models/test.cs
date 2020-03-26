using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using BackEnd.Data;
using System.Linq;
using System;
namespace BackEnd.Models
{
    public class test
    {
        public int TestId { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Date { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string nbcandidat { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        
        public string heure { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        
        public ICollection<Candidature> Candidature { get; set; }
        public ICollection<Question> Questions { get; set; }
        public override string ToString() => JsonSerializer.Serialize<test>(this);

    }
}
