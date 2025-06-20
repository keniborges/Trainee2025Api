using System.ComponentModel.DataAnnotations;

namespace Senai2025Api.Entidades
{
    public class Escola : BaseEntity
    {
        [MaxLength(60), Required]
        public string Nome { get; set; }

        public Endereco Endereco { get; set; }

        public List<Professor> Professores { get; set; }
    }
}
