using System.ComponentModel.DataAnnotations;

namespace zSolutions.Models.Contact
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required!")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required!")]
        [StringLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mobile no. is required")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        public string Phone { get; set; }
        [Required]
        public DateTime Send { get; set; }
        [Required(ErrorMessage = "Message is required!")]
        public string Message { get; set; }

    }
}
