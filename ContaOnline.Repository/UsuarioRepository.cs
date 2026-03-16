using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContaOnline.Domain.Models;
using ContaOnline.Domain.Interfaces;

namespace ContaOnline.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Alterar(IUsuarioRepository entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(string id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(IUsuarioRepository entidade)
        {
            throw new NotImplementedException();
        }

        public Usuario ObeterPorEmailSenha(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public IUsuarioRepository ObterPorId(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IUsuarioRepository> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
