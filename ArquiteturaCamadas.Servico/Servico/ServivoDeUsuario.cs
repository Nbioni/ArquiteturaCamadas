// ------------------------------------------------------------------------------------------------------------------
//  <copyright file="ServivoDeUsuario.cs" company="Nahaliel Bioni">
//  Copyright (c) 2019. Todos os Direitos Reservados
//  </copyright>
// ------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArquiteturaCamadas.Interfaces.Dtos;
using ArquiteturaCamadas.Enumeradores.Enumeradores;
using ArquiteturaCamadas.Servico.Repositorio.Repositorios;
using ArquiteturaCamadas.Servico.Conversores;

namespace ArquiteturaCamadas.Servico.Servico
{
    class ServivoDeUsuario
    {
        public List<DtoUsuarios> BuscaTodosUsuarios()
        {
            // Faz as validações e depois chama o repositorio para buscar

            // ----------- validações ---------------

            RepositorioDeUsuarios repositorioDeUsuarios = new RepositorioDeUsuarios();
            var resultado = repositorioDeUsuarios.BuscaTodosUsuarios();
            var conversorDeUsuarios = new ConversorDeUsuarios();
            var listaUsuarios = new List<DtoUsuarios>();
            foreach (var obj in resultado)
            {
                listaUsuarios.Add(conversorDeUsuarios.ConverteObj(obj));
            }
            return listaUsuarios;
        }

        public DtoUsuarios BuscaUsuarioPorId(long id)
        {
            // Faz as validações e depois chama o repositorio para buscar

            // ----------- validações ---------------

            RepositorioDeUsuarios repositorioDeUsuarios = new RepositorioDeUsuarios();
            var resultado = repositorioDeUsuarios.BuscaUsuarioPorId(id);
            var conversorDeUsuarios = new ConversorDeUsuarios();

            return conversorDeUsuarios.ConverteObj(resultado);
        }

        public IEnumerable<DtoUsuarios> BuscaUsuariosPorTipo(EnumTipoUsuarios tipoUsuarios)
        {
            // Faz as validações e depois chama o repositorio para buscar

            // ----------- validações ---------------

            RepositorioDeUsuarios repositorioDeUsuarios = new RepositorioDeUsuarios();
            var resultado = repositorioDeUsuarios.BuscaUsuariosPorTipo(tipoUsuarios);
            var conversorDeUsuarios = new ConversorDeUsuarios();
            var listaUsuarios = new List<DtoUsuarios>();
            foreach (var obj in resultado)
            {
                listaUsuarios.Add(conversorDeUsuarios.ConverteObj(obj));
            }
            return listaUsuarios;
        }

        public void SalvaUsuario(DtoUsuarios usuario)
        {
            // Faz as validações necessários e caso nenhum erro salva no banco de dados
            try
            {
                // ----------- validações ---------------

                RepositorioDeUsuarios repositorioDeUsuarios = new RepositorioDeUsuarios();
                var conversorDeUsuarios = new ConversorDeUsuarios();
                repositorioDeUsuarios.SalvaUsuario(conversorDeUsuarios.ConverteDto(usuario));
            }
            catch ( Exception err)
            {
                throw err;
            }
        }
    }
}
