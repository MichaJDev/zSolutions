using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using zSolutions.Models.Users;

namespace zSolutions.Models.Jobs
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public User Client { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public string GitHub { get; set; }
        [NotMapped]
        public List<User>? AttendingUsers { get; set; }
        [NotMapped]
        public User Teacher { get; set; }
    }
}
