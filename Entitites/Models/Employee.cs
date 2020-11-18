using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entitites.Models
{
    public class Employee
    {
        [Column("EmployeeId")]  
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Employee Name is required Field")]
        [MaxLength(30 , ErrorMessage ="Maximum length for the name is 30 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Position Name is required Field")]
        [MaxLength(20, ErrorMessage = "Maximum length for the name is 20 characters")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Age Name is required Field")]
        public int Age { get; set; }

        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
