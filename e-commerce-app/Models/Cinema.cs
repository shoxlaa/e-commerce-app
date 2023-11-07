using System.ComponentModel.DataAnnotations;

namespace e_commerce_app.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relotionshps 

        public List<Movie> Movies { get; set; }
    }


}

