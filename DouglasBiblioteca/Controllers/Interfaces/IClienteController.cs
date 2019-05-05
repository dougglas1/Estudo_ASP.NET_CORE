using DouglasBiblioteca.Models;
using System.Collections.Generic;

namespace DouglasBiblioteca.Controllers.Interfaces
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
