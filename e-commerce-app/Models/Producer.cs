using e_commerce_app.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace e_commerce_app.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set;}
        [Display (Name="Name")]
        [Required(ErrorMessage = "Name is required")]
        public string FullName { get; set; }
        [Display (Name = "Biography")]
        [Required(ErrorMessage = "Bio is required")]

        public string Bio { get; set;}
        [Display (Name= "Profile Picture URL")]
        [Required(ErrorMessage ="Profile pic is required")]
        public string ProfilePictureURL { get; set; }


        //Relationships 

        public List<Movie>? Movies { get; set; }
    }
}

