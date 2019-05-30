// ------------------------------------------------------------------------------------------------------------------
//  <copyright file="RepositorioDeUsuarios.cs" company="Nahaliel Bioni">
//  Copyright (c) 2019. Todos os Direitos Reservados
//  </copyright>
// ------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using ArquiteturaCamadas.Enumeradores.Enumeradores;
using ArquiteturaCamadas.Servico.Repositorio.Negocio;

namespace ArquiteturaCamadas.Servico.Repositorio.Interfaces
{
    public interface IRepositorioDeUsuarios
    {
        /// <summary>
        /// Busca todas os usuários.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Usuarios> BuscaTodosUsuarios();

        /// <summary>
        /// Busca Usuário por Id
        /// </summary>
        /// <returns></returns>
        Usuarios BuscaUsuarioPorId(long id);

        /// <summary>
        /// Busca Usuário por tipo (Cliente ou Moderador)
        /// </summary>
        /// <returns></returns>
        IEnumerable<Usuarios> BuscaUsuariosPorTipo(EnumTipoUsuarios tipoUsuarios);

        void SalvaUsuario(Usuarios usuario);
    }
}
