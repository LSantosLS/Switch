using Switch.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace Switch.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; private set; }
        [MaxLength(500)]
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public string UrlFoto { get; set; }
        public SexoEnum Sexo { get; set; }
    }
}
