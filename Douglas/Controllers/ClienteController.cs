using Douglas.Controllers.Interfaces;
using Douglas.Dao;
using Douglas.Dao.Interfaces;
using Douglas.Models;
using Douglas.UnitOfWork;
using System;
using System.Collections.Generic;

namespace Douglas.Controllers
{
    public class ClienteController : IClienteController
    {
        private IClienteDao clienteDao;

        public ClienteController()
        {
            clienteDao = new ClienteDao(UnitOfWorkFactory.Create());
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
            return clienteDao.BuscarTodos();
        }

        public Cliente BuscarPorId(double id)
        {
            return clienteDao.BuscarPorId(id);
        }
    }
}
