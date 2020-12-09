using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace WebAPI.Models
{
    public class User
    {
        
        [Key]
        private int Id { get; set; }
        private string Username { get; set; }
        private string Full_name { get; set; }
        private string Avatar { get; set; }
        private DateTime Created_At { get; set; }     
        private DateTime Updated_At { get; set; }     
        private List<Repository> Repository { get; set; }  

    }
}

// id int not null auto_increment,
// username varchar(100) not null,
// full_name varchar(100) not null,
// email varchar(255) not null,
// avatar varchar not null,
// created_at datetime not null default current_timestamp,
// updated_at datetime not null default current_timestamp,