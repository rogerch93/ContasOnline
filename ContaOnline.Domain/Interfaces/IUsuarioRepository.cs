using ContaOnline.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaOnline.Domain.Interfaces
{
    public interface IUsuarioRepository:IRepository<IUsuarioRepository>
    {
        Usuario ObeterPorEmailSenha(string email, string senha);
    }
}
