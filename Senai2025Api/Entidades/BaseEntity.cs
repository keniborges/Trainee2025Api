
using System.ComponentModel.DataAnnotations;

namespace Senai2025Api.Entidades
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
