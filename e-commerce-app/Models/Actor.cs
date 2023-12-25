using System.ComponentModel.DataAnnotations;

namespace e_commerce_app.Models
{
    public class Actor
    {
        [Key]
        public int? Id { get; set; }
        [Display(Name= "Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]

        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage ="Biography is required")]
        public string Bio { get; set; }

        [Required(ErrorMessage ="Profile Picture is required ")]
        [Display(Name  = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }

        //Relationships

        public List<Actor_Movie>? Actor_Movies { get; set; }

    }
}

