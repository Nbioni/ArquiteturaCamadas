// ------------------------------------------------------------------------------------------------------------------
//  <copyright file="Usuarios.cs" company="Nahaliel Bioni">
//  Copyright (c) 2019. Todos os Direitos Reservados
//  </copyright>
// ------------------------------------------------------------------------------------------------------------------

using System;
using ArquiteturaCamadas.Enumeradores.Enumeradores;

namespace ArquiteturaCamadas.Servico.Repositorio.Negocio
{
    public class Usuarios
    {
        public long Id { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string NomeCompleto { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public long CPF { get; set; }

        public long RG { get; set; }

        public DateTime? DataNascimento { get; set; }

        public DateTime? DataCriacaoUsuario { get; set; }

        public EnumTipoUsuarios TipoUsuario { get; set; }
    }
}
