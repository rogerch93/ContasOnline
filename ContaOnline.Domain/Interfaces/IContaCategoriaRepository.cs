using ContaOnline.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaOnline.Domain.Interfaces
{
    public interface IContaCategoriaRepository
    {
        void Incluir(ContaCategoria contaCategoria);
        void Alterar(ContaCategoria contaCategoria);
        void Excluir(string id);
        ContaCategoria ObterPorId(string id);
        IEnumerable<ContaCategoria> ObterTodos();
    }
}
