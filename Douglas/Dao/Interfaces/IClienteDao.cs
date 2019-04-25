using Douglas.Models;
using System;
using System.Collections.Generic;

namespace Douglas.Dao.Interfaces
{
    public interface IClienteDao
    {
        int Inserir(Cliente obj);
        int Atualizar(Cliente obj);
        int ExcluirPorId(double id);
        List<Cliente> BuscarTodos();
        Cliente BuscarPorId(double id);
    }
}
