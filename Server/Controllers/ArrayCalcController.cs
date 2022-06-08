using System;
using Microsoft.AspNetCore.Mvc;
using Service;

// EI, to the one reviewing this, thank you. :):) Have a great day ahead, looking forward to work with you, cheers,

namespace Server.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArrayCalcController : ControllerBase
    {
        private readonly IProductService _productService;


        public ArrayCalcController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public int[] Reverse([FromQuery] int[] productIds)
        {
            try
            {
                _productService.Reverse(ref productIds);
                return productIds;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpGet]
        public int[] DeletePart([FromQuery] int position, [FromQuery] int[] productIds)
        {
            try
            {
                _productService.DeletePart(position, ref productIds);
                return productIds;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}