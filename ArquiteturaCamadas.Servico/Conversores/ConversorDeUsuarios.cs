// ------------------------------------------------------------------------------------------------------------------
//  <copyright file="ConversorDeUsuarios.cs" company="Nahaliel Bioni">
//  Copyright (c) 2019. Todos os Direitos Reservados
//  </copyright>
// ------------------------------------------------------------------------------------------------------------------

using ArquiteturaCamadas.Interfaces.Dtos;
using ArquiteturaCamadas.Servico.Repositorio.Negocio;

namespace ArquiteturaCamadas.Servico.Conversores
{
    public class ConversorDeUsuarios
    {
        public Usuarios ConverteDto(DtoUsuarios dto)
        {
            // Converte o Dto em Obj. de Negócio para ser salvo no banco de dados        
            Usuarios obj = new Usuarios();
            obj.Id = dto.Id;
            obj.Login = dto.Login;
            obj.NomeCompleto = dto.NomeCompleto;
            obj.RG = dto.RG;
            obj.Senha = dto.Senha;
            obj.Telefone = dto.Telefone;
            obj.TipoUsuario = dto.TipoUsuario;
            return obj;
        }

        public DtoUsuarios ConverteObj(Usuarios obj)
        {
            // Converte o Obj. de Negócio para o Dto para ser trabalhado no front-end
            // Converte o Dto em Obj. de Negócio para ser salvo no banco de dados        
            DtoUsuarios dto = new DtoUsuarios();
            dto.Id = obj.Id;
            dto.Login = obj.Login;
            dto.NomeCompleto = obj.NomeCompleto;
            dto.RG = obj.RG;
            // Não trazemos para o front a senha, ela poderá apenas ser alterada e não poderá ser visualizada
            // dto.Senha = obj.Senha; 
            dto.Telefone = obj.Telefone;
            dto.TipoUsuario = obj.TipoUsuario;
            return dto;
        }
    }
}
