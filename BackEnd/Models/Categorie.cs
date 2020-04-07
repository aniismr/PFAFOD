using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
namespace BackEnd.Models
{
    public class Categorie
    {
        public int CategorieID { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Libelle { get; set; }
    }
}
