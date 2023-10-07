using e_commerce_app.Data;
using System.ComponentModel.DataAnnotations;

namespace e_commerce_app.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }  
        public string ProfilePictureUrl { get; set; }
        public string Bio { get; set; } 

    }

    public class Producer
    {
        [Key]
        public int ProducerId { get; set;}
        public string ProfilePictureUrl { get; set; }

        public string FullName { get; set; }
        public string Bio { get; set;} 
    }

    public class Cinema
    {
        [Key]   
        public int CinemaId { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Movie
    {
        [Key]
        public int MovieId { get; set; }     
        public string Name { get; set; }
        public string Description { get; set; }  
        public double Price { get ; set; }   
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
    }
}

