﻿using System.ComponentModel.DataAnnotations;

namespace Senai2025Api.Entidades
{
    public class Aluno : BaseEntity
    {
        [MaxLength(60), Required]
        public string Nome { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }

        [MaxLength(14), Required]
        public string Cpf { get; set; }

        public long ClasseId { get; set; }
        public Classe Classe { get; set; }  

    }
}
