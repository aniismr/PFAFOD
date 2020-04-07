using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace BackEnd.Models
{
    public class TestCategorie
    {
        public int TestCategorieID { get; set; }
        public int TestID { get; set; }
        public int CategorieID { get; set; }
        public Categorie Categorie { get; set; }
        public Test Test { get; set; }
        public int NbQuestion {get;set;}
        public override string ToString() => JsonSerializer.Serialize<TestCategorie>(this);
    }
}
