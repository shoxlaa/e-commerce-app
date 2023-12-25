using System.ComponentModel.DataAnnotations;

namespace e_commerce_app.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display (Name ="Poster")]
        public string Logo { get; set; }
        [Display(Name="Cinema Name")]
        public string Name { get; set; }
        [Display(Name="Description")]
        public string Description { get; set; }

        //Relotionshps 

        public List<Movie> Movies { get; set; }
    }


}

