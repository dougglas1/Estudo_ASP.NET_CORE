using Douglas.Models;
using System;
using System.Collections.Generic;

namespace Douglas.Controllers.Interfaces
{
    public interface IClienteController
    {
        int Inserir(Cliente obj);
        int Atualizar(Cliente obj);
        int ExcluirPorId(double id);
        List<Cliente> BuscarTodos();
        Cliente BuscarPorId(double id);        
    }
}
