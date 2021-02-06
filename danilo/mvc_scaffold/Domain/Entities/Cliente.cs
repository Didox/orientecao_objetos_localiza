using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_scaffold.Models.Domain.Entities
{
  [Table("tbl_client")]
  public class Cliente
  {
    [Key]
    [Required]
    public int Id {get;set;}

    [Required]
    [MaxLength(150)]
    [Column("client_nome")]
    public string Nome {get;set;}

    [Required]
    [MaxLength(15)]
    public string CPF {get;set;}

    [MaxLength(15)]
    public string Telefone {get;set;}
    
    [Column(TypeName = "Text")]
    public string Endereco { get; set; }
  }
}