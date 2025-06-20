using System.ComponentModel.DataAnnotations;

namespace Senai2025Api.Entidades
{
    public class Professor : BaseEntity
    {
        [MaxLength(60), Required]
        public string Nome { get; set; }

        public Classe Classe { get; set; }

        public long EscolaId { get; set; }
        public Escola Escola { get; set; }

    }
}
