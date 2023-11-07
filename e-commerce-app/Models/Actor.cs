using System.ComponentModel.DataAnnotations;

namespace e_commerce_app.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }  
        public string FullName { get; set; }
        public string Bio { get; set; }
        public string ProfilePictureURL { get; set; }

        //Relationships

        public List<Actor_Movie> Actor_Movies { get; set; }

    }
}

