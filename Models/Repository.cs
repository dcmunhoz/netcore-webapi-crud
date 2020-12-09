using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Repository
    {
        
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string description { get; set; }
        public User User { get; set; }

    }
}


// `id` int NOT NULL AUTO_INCREMENT,
// `name` varchar(100) NOT NULL,
// `url` varchar(1000) DEFAULT NULL,
// `description` varchar(250) DEFAULT NULL,
// `user_id` int NOT NULL,