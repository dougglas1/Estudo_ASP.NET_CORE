using DouglasBiblioteca.Models;
using System.Collections.Generic;

namespace DouglasBiblioteca.Dao.Interfaces
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
