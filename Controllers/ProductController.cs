using Microsoft.AspNetCore.Mvc;
using FetchWebapi.Data;
using FetchWebapi.Model;
using Microsoft.EntityFrameworkCore;
namespace FetchWebapi.Controllers{
[ApiController]
  public class FetchProductController : ControllerBase{
      private readonly Appdbcontext context;
        public FetchProductController(Appdbcontext context){
            this.context=context; 
        }
    // [EnableCors("myAppCors")]
    [Route("api/FetchProduct")]
     [HttpGet]
        public async Task<IEnumerable<Vehicle>>Get(){
            return await context.VehicleDetails.ToListAsync();
        }
        [Route("api/FetchProduct/{id}")]
        [HttpGet]
        public ActionResult<Vehicle> GetIndividual(int id)
        {
           var Vehicle = context.VehicleDetails.Find(id);
           if (Vehicle == null)
           {
             return NotFound();
           }
           return Ok(Vehicle);
         }

        }
}
    
