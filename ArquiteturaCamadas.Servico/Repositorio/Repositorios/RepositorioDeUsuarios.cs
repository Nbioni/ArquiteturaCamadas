// ------------------------------------------------------------------------------------------------------------------
//  <copyright file="RepositorioDeUsuarios.cs" company="Nahaliel Bioni">
//  Copyright (c) 2019. Todos os Direitos Reservados
//  </copyright>
// ------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using ArquiteturaCamadas.Servico.Repositorio.Negocio;
using ArquiteturaCamadas.Enumeradores.Enumeradores;

namespace ArquiteturaCamadas.Servico.Repositorio.Repositorios
{
    public class RepositorioDeUsuarios
    {
        public List<Usuarios> BuscaTodosUsuarios()
        {
            var listaUsuarios = new List<Usuarios> ();

            // Faz a consulta no banco e retorna a lista

            return listaUsuarios;
        }

        public Usuarios BuscaUsuarioPorId(long id)
        {
            var usuario = new Usuarios();

            // Faz a consulta por id no banco e retorna o Obj. Usuario

            return usuario;
        }

        public List<Usuarios> BuscaUsuariosPorTipo(EnumTipoUsuarios tipoUsuarios)
        {
            var listaUsuarios = new List<Usuarios>();

            // Faz a consulta no banco e retorna a lista

            return listaUsuarios;
        }

        public void SalvaUsuario(Usuarios usuario)
        {
            // Tenta salvar, caso algum erro lança a exceção com o erro
            try
            {
                // Salva o usuário no banco de dados
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
