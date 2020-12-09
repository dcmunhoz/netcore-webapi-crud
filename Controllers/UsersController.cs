using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UsersController : ControllerBase
    {
        
        /*
            List Github users in database.
        */
        [HttpGet]
        public ActionResult Get()
        {
            
            return Ok("Olá mundo, estou Funcionando !!!! ");

        }


    }
}