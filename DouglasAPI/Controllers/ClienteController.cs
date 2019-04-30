using System.Collections.Generic;
using Douglas.Controllers.Interfaces;
using Douglas.Models;
using Microsoft.AspNetCore.Mvc;

namespace DouglasAPI.Controllers
{
    [Route("api/[controller]")]
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
        public IEnumerable<Cliente> BuscarTodosClientes()
        {
            return clienteController.BuscarTodos();
        }
    }
}
