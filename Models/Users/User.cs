using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zSolutions.Models.Users
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Surename { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        public bool Invited { get; set; }
        [NotMapped]
        public bool IsEmailConfirmed { get; set; }
        [Required]
        public List<User>? Mentees { get; set; }
        [NotMapped]
        public User? Mentor { get; set; }
        [StringLength(50)]
        public String? Company { get; set; }
    }
}
