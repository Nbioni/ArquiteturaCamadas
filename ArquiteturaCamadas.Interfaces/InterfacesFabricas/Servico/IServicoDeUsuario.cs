// ------------------------------------------------------------------------------------------------------------------
//  <copyright file="IServicoDeUsuario.cs" company="Nahaliel Bioni">
//  Copyright (c) 2019. Todos os Direitos Reservados
//  </copyright>
// ------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using ArquiteturaCamadas.Enumeradores.Enumeradores;
using ArquiteturaCamadas.Interfaces.Dtos;

namespace ArquiteturaCamadas.Interfaces.InterfacesFabricas.Servico
{
    public interface IServicoDeUsuario
    {        
        /// <summary>
        /// Busca todas os usuários.
        /// </summary>
        /// <returns></returns>
        List<DtoUsuarios> BuscaTodosUsuarios();
        
        /// <summary>
        /// Busca Usuário por Id
        /// </summary>
        /// <returns></returns>
        DtoUsuarios BuscaUsuarioPorId(long id);

        /// <summary>
        /// Busca Usuário por tipo (Cliente ou Moderador)
        /// </summary>
        /// <returns></returns>
        List<DtoUsuarios> BuscaUsuariosPorTipo(EnumTipoUsuarios tipoUsuarios);

        void SalvaUsuario(DtoUsuarios usuario);
    }
}
