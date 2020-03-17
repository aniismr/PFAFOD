using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FodApi.Model
{
    public class Candidature
    {    
        [Key]
        public int id { get; set; }
        public string datepostulation { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string type { get; set; }
        public ICollection<Candidat> candidat { get; set; }
        public ICollection<Competence> competence { get; set; }
        public string cv { get; set; }
        public string status { get; set; }
    }
}