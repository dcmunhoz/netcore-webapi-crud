using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace WebAPI.Models
{
    public class User
    {
        
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Full_name { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public DateTime Created_At { get; set; }     
        public DateTime Updated_At { get; set; }     
        public List<Repository> Repository { get; set; }  

    }
}

// id int not null auto_increment,
// username varchar(100) not null,
// full_name varchar(100) not null,
// email varchar(255) not null,
// avatar varchar not null,
// created_at datetime not null default current_timestamp,
// updated_at datetime not null default current_timestamp,