using System.ComponentModel.DataAnnotations;

namespace e_commerce_app.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set;}
        [Display (Name="Name")]
        public string FullName { get; set; }
        [Display (Name = "Biography")]
        public string Bio { get; set;}
        [Display (Name= "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }


        //Relationships 

        public List<Movie> Movies { get; set; }
    }
}

