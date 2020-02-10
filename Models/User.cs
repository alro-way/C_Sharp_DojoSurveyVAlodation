using System;
using System.ComponentModel.DataAnnotations;


namespace C_Sharp_DojoSurveyVAlodation.Models
{
    public class User
    {
        [Required]
        [MinLength(2, ErrorMessage="Name must be at least 2 characters")]
        [Display(Name = "Your Name'")] 
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        [MaxLength(20,ErrorMessage = "Comment must contain no more than 20 characters")]
        public string Comment { get; set; }

    }
}