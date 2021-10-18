using System.ComponentModel.DataAnnotations;

namespace _2Read_Application.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter the Book Name.")]
        [Display(Name ="Book Name")]
        public string Name { get; set; }

        [Display(Name ="Author's Name")]
        [StringLength(60, MinimumLength = 3)]
        public string Author { get; set; }
    }
}