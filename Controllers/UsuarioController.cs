using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPICadCliente.Models;

namespace WebAPICadCliente.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        private static List<UsuarioModelo> listaUsuarios = new List<UsuarioModelo>();

        [AcceptVerbs("POST")]
        [Route("CadastrarUsuario")]
        public string CadastrarUsuario(UsuarioModelo usuario)
        {

            listaUsuarios.Add(usuario);
            return "Usuario cadastrado com sucesso";
        }

        [AcceptVerbs("PUT")]
        [Route("AlterarUsuario")]
        public string AlterarUsuario (UsuarioModelo usuario)
        {
            listaUsuarios.Where(n => n.Codigo == usuario.Codigo)
                .Select(s =>
                {
                    s.Codigo = usuario.Codigo;
                    s.Login = usuario.Login;
                    s.Nome = usuario.Nome;

                    return s;
                }).ToList();

            return "Usuário alterado com sucesso!";

        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluirUsuario/{codigo}")]
        public string ExcluirUsuario(int codigo)
        {

            UsuarioModelo usuario = listaUsuarios.Where(n => n.Codigo == codigo)
                                                .Select(n => n)
                                                .FirstOrDefault();

            listaUsuarios.Remove(usuario);

            return "Registro excluido com sucesso!";
        }

        //[HttpGet]
        [AcceptVerbs("GET")]
        [Route("ConsultarUsuarioPorCodigo/{codigo}")]
        public UsuarioModelo ConsultarUsuarioPorCodigo(int codigo)
        {

            UsuarioModelo usuario = listaUsuarios.Where(n => n.Codigo == codigo)
                                                .Select(n => n)
                                                .FirstOrDefault();

            return usuario;
        }

        // [HttpGet]
        [AcceptVerbs("GET")]
        [Route("ConsultarUsuario")]
        public List<UsuarioModelo> ConsultarUsuarios()
        {
            return listaUsuarios;
        }
        
    }
}
