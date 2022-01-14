using DevIO.UI.Site.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.Site.Modulos.Vendas.Controllers
{
    [Area("Vendas")]
    public class PedidosController : Controller
    {
        private readonly IPedidoRepository _repository;

        public PedidosController(IPedidoRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var pedido = _repository.ObterPedido();
            return View();
        }
    }
}
