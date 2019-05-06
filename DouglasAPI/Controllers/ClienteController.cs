using System.Collections.Generic;
using DouglasBiblioteca.Controllers.Interfaces;
using DouglasBiblioteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace DouglasAPI.Controllers
{
    [Route("api/Cliente/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteController clienteController;

        public ClienteController(IClienteController clienteController)
        {
            this.clienteController = clienteController;
        }

        /// <summary>
        /// Buscar todos os clientes cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Cliente> BuscarTodos()
        {
            return clienteController.BuscarTodos();
        }

        /// <summary>
        /// Buscar o Cliente pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Cliente BuscarPorID(double id)
        {
            return clienteController.BuscarPorId(id);
        }

        /// <summary>
        /// Inserir um novo Cliente
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Inserir(Cliente obj)
        {
            return clienteController.Inserir(obj);
        }

        /// <summary>
        /// Atualizar um Cliente
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Atualizar(Cliente obj)
        {
            return clienteController.Atualizar(obj);
        }

        /// <summary>
        /// Excluir Cliente por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int ExcluirPorId(double id)
        {
            return clienteController.ExcluirPorId(id);
        }
    }
}
