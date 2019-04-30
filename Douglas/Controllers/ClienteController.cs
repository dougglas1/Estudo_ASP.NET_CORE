using Douglas.Controllers.Interfaces;
using Douglas.Dao.Interfaces;
using Douglas.Models;
using DouglasInfra.UnitOfWork;
using System.Collections.Generic;

namespace Douglas.Controllers
{
    public class ClienteController : IClienteController
    {
        // Conexão
        private readonly IUnitOfWork unitOfWork;

        private IClienteDao clienteDao;

        public ClienteController(IClienteDao clienteDao,
                                IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.clienteDao = clienteDao;
        }

        public int Inserir(Cliente obj)
        {
            return clienteDao.Inserir(obj);
        }

        public int Atualizar(Cliente obj)
        {
            return clienteDao.Atualizar(obj);
        }

        public int ExcluirPorId(double id)
        {
            return clienteDao.ExcluirPorId(id);
        }        

        public List<Cliente> BuscarTodos()
        {
            List<Cliente> listaCliente = clienteDao.BuscarTodos();
            return listaCliente;
        }

        public Cliente BuscarPorId(double id)
        {
            return clienteDao.BuscarPorId(id);
        }
    }
}
