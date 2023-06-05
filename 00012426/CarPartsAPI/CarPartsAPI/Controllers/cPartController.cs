using System.Transactions;
using Microsoft.AspNetCore.Mvc;
using OnlineStoreAPI.Models;
using OnlineStoreAPI.Repositories;

namespace OnlineStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class cPartController : ControllerBase
    {
        private readonly ICPartRepository __cPartRepository;

        public cPartController(ICPartRepository cPartRepository)
        {
            __cPartRepository = cPartRepository;

        }

        // GET: 
        [HttpGet]
        public IActionResult Get() 
        {
            return new OkObjectResult(__cPartRepository.RetrieveAll());
        }

        // GET: 
        [HttpGet("{id}", Name ="GetProductByID")]
        public IActionResult GetProductById(int ID) 
        {
            return new OkObjectResult(__cPartRepository.RetrieveByID(ID));
        }

        // PUT: 
        [HttpPut("{id}")]
        public IActionResult UpdateProduct([FromBody] cPart oProduct) 
        {
            if (oProduct != null) 
            {
                using (var scope = new TransactionScope()) 
                {
                    __cPartRepository.UpdateProduct(oProduct);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        // POST: 

        [HttpPost]
        public IActionResult CreateNewProduct(cPart oProduct) 
        {
            using (var scope = new TransactionScope())
            {
                __cPartRepository.CreateNewProduct(oProduct);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { ID = oProduct.Id }, oProduct);
            }

        }

        // DELETE: 
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int ID) 
        {

            __cPartRepository.DeleteProductByID(ID);
            return new OkResult();
        }
    }
}
