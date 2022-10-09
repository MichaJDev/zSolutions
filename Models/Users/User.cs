using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using zSolutions.Models.Jobs;
using zSolutions.Models.Utils;

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
        public string Surname { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        public bool? IsEmailConfirmed { get; set; }
        [StringLength(50)]
        public String? Company { get; set; }
        [Required]
        public UserType UserType { get; set; }
        public int JobId { get; set; }
        public List<Job>? Jobs { get; set; }
    }
}
