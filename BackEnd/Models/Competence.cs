using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace BackEnd.Models
{
public class Competence
{

public int CompetenceID { get; set; }
public string CompetenceName { get; set; }
public override string ToString() => JsonSerializer.Serialize<Competence>(this);

}
}