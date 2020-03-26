using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
namespace BackEnd.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string ennonce { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string rep1 { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string rep2 { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string rep3 { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string reptrue { get; set; }
        public int CategorieID { get; set; }
        public Categorie Categorie { get; set; }

    }
}
