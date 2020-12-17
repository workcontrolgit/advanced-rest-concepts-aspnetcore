using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataServices.Domain.Models
{
    [Table("assignment")]
    public class Assignment : IEntity
    {
        [Key]
        [Column("AssignmentId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Date created is required")]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Assignment type is required")]
        public string AssignmentType { get; set; }

        [Required(ErrorMessage = "Employee Id is required")]
        public Guid EmployeeId { get; set; }
    }
}
