using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPICadCliente.Models
{
    public class UsuarioModelo
    {
        private int codigo;
        private string nome;
        private string login;

        public UsuarioModelo()
        {

        }
        public UsuarioModelo(int codigo, string nome, string login)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Login = login;

        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Login { get => login; set => login = value; }
    }

}


/*
 * 
 * {
        "Codigo":1,
        "Nome":"Daniel",
        "Login":"daniel"
   }
*/
