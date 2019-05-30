// ------------------------------------------------------------------------------------------------------------------
//  <copyright file="DtoUsuarios.cs" company="Nahaliel Bioni">
//  Copyright (c) 2019. Todos os Direitos Reservados
//  </copyright>
// ------------------------------------------------------------------------------------------------------------------

using System;
using ArquiteturaCamadas.Enumeradores.Enumeradores;

namespace ArquiteturaCamadas.Interfaces.Dtos
{
    public class DtoUsuarios
    {
        public long Id { get; set; }

        public string Login { get; set; }

        // Nunca será utilizado para apresentar a senha na tela, será apenas usado para salvar no banco
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