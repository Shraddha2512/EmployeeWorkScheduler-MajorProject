using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EmployeeWorkScheduler.Web.Models
{
    [Table(name: "AssignedTasks")]
    public class AssignedTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Task ID")]
        public int TaskId { get; set; }

        [Required]
        [Display(Name = "Task Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Assigned Date")]
        public System.DateTime AssignedDate { get; set; }

        [Required]
        [Display(Name = "Due Date")]
        public System.DateTime DueDate { get; set; }

        [Required]
        public string Status { get; set; }



        #region 
        [Required]
        virtual public int EmpId { get; set; }

        [ForeignKey(nameof(AssignedTask.EmpId))]
        public Employee Employee { get; set; }

        [Required]
        virtual public int ManagerId { get; set; }

        [ForeignKey(nameof(AssignedTask.ManagerId))]
        public Admin Admin { get; set; }

        #endregion
    }
}

