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
        public int QuestionID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Ennonce { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Rep1 { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Rep2 { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Rep3 { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string RepTrue { get; set; }
        public int CategorieID { get; set; }
        public Categorie Categorie { get; set; }

    }
}
