using System.ComponentModel.DataAnnotations;
using Senai2025Api.Entidades.Enums;

namespace Senai2025Api.Entidades
{
    public class Classe : BaseEntity
    {
        [Required]
        public SerieEnum Serie { get; set; }

        public long ProfessorId { get; set; }
        public Professor Professor { get; set; }

        public List<Aluno> Alunos { get; set; }

    }
}
