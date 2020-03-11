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
        public int id_candidature { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string type { get; set; }
        [DataType(DataType.Date)]
        public DateTime datecandidature { get; set; }
        public ICollection<Competence> competences { get; set; }

    }
}