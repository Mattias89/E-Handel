using E_Handel.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_Handel.Controllers
{
    [Route("produkt")]
    public class ProduktController : ControllerBase
    {
        private readonly IProduktService _produktService;
        public ProduktController(IProduktService produktService) {
                _produktService = produktService;
        }

        [HttpGet]
        public IActionResult GetProdukter()
        {
            return Ok(_produktService.GetAllProducts());
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById([FromRoute] int id)
        {
            return Ok(_produktService.GetProductById(id));
        }

    }
}
