using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using zSolutions.Models.Users;
using zSolutions.Models.Utils;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace zSolutions.Models.Jobs
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Description is required!")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "GitHub link is required!")]
        [Url]
        public string? GitHub { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        [Display(Name = "Status")]
        public JobStatusType Status { get; set; }
        [NotMapped]
        public List<User>? Attendees { get; set; }
        [NotMapped]
        public User? Client { get; set; }
    }
}
