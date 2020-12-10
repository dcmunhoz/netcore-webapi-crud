using System.Net;
using System.Net.Http;
using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Data;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UsersController : ControllerBase
    {
        
        private readonly DataContext dataContext;
        private readonly HttpClient httpClient;

        public UsersController(DataContext data, IHttpClientFactory http)
        {
            this.dataContext = data;
            this.httpClient = http.CreateClient("GithubAPI");
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
            Return an specific user from b.
        */
        [HttpGet("{username}")]
        public async Task<ActionResult<User>> GetUser(string username)
        {
            GithubUser githubUser = new GithubUser();
            User user = dataContext.users.SingleOrDefault<User>(x => x.Username == username) ?? new User();
            // List<User> user2 = dataContext.users.FromSqlRaw("SELECT * FROM users;").ToList<User>();

            if (user.Username == null) {
                // Busca na API do Github
                var response = await httpClient.GetAsync($"/users/{username}");

                if ( !response.IsSuccessStatusCode ) return BadRequest(new { Error = "Usuário não localizado no Github" });
                
                using var stream = await response.Content.ReadAsStreamAsync();

                githubUser = await JsonSerializer.DeserializeAsync<GithubUser>(stream);
        
                user.Username   = githubUser.login;
                user.Full_name  = githubUser.name;
                user.Avatar     = githubUser.avatar_url;
                dataContext.Add(user);
                dataContext.SaveChanges();
            }
            return Ok(user);
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