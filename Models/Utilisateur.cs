using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FodApi.Model
{
    public class Utilisateur
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName ="nvarchar(20)")]
        [Required]
        public string photo { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string nom { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string prenom { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string email { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string mdp {get;set;}

        public ICollection<Role> role  {get;set;}

    }
}