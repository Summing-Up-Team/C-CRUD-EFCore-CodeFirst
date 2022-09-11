using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C_CRUD_EFCore_CodeFirst.Core.Entidades
{
    [Table(name:"Desenvolvedor")]
    public class Desenvolvedor
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(120)]
        public string Nome { get; set; }

        [Required]
        public int Idade { get; set; }
    }
}
