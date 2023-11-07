using System.ComponentModel.DataAnnotations;

namespace e_commerce_app.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }  
        public string ProfilePictureUrl { get; set; }
        public string Bio { get; set; }

        //Relationships

        public List<Actor_Movies> Actor_Movies { get; set; }

    }
}

