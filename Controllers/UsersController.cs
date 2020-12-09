using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebAPI.Models;
using WebAPI.Data;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UsersController : ControllerBase
    {
        
        private readonly DataContext dataContext;

        public UsersController(DataContext data)
        {
            this.dataContext = data;
        }

        /*
            List Github users in database.
        */
        [HttpGet]
        public ActionResult Get()
        {
            
            return Ok("Olá mundo, estou Funcionando !!!! ");

        }

        /*
            Insere um usuário no banco de dados.
        */
        [HttpPost]
        public ActionResult Post(User sendedUser)
        {
            
            dataContext.users.Add(sendedUser);
            dataContext.SaveChanges();
        
            return Ok(sendedUser);

        }


    }
}