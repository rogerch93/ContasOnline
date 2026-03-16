using ContaOnline.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaOnline.Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Incluir(T entidade);
        void Alterar(T contaCategoria);
        void Excluir(string id);
        T ObterPorId(string id);
        IEnumerable<T> ObterTodos();
    }
}
