﻿using Switch.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

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
        public virtual Identificacao Identificacao { get; set; }
        public virtual StatusRelacionamento StatusRelacionamento { get; set; }
        public virtual ProcurandoPor ProcurandoPor { get; set; }
        public virtual ICollection<Postagem> Postagens { get; set; }
        public virtual ICollection<UsuarioGrupo> UsuarioGrupos { get; set; }
        public virtual ICollection<LocalTrabalho> LocaisTrabalho { get; set; }
        public virtual ICollection<InstituicaoEnsino> InstitucoesEnsino { get; set; }
        public virtual ICollection<Amigo> Amigos { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }

        public Usuario()
        {
            Postagens = new List<Postagem>();
            UsuarioGrupos = new List<UsuarioGrupo>();
            LocaisTrabalho = new List<LocalTrabalho>();
            InstitucoesEnsino = new List<InstituicaoEnsino>();
            Amigos = new List<Amigo>();
            Comentarios = new List<Comentario>();
        }
    }
}
