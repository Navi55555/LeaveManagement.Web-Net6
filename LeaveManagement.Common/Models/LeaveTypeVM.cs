using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.Common.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Leave Type Name")]
        public string Name { get; set; }
        
        [Display(Name = "Default Number of Days")]
        [Required]
        [Range(1, 25, ErrorMessage = "Please Enter a Valid Number")]
        public int DefaultDays { get; set; }
    }
}
