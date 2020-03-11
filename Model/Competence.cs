using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FodApi.Model
{
    public class Competence
    {   [Key]
        [Column(TypeName = "nvarchar(100)")]
        public int id_competence { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string libele { get; set; }

    }
}