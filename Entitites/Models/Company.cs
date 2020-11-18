using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entitites.Models
{
    
    public class Company
    {
        [Column("CompanyId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Company Name is required Field")]
        [MaxLength(30, ErrorMessage = "Maximum length for the name is 30 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is required Field")]
        [MaxLength(100, ErrorMessage = "Maximum length for the Address is 100 characters")]
        public string Address { get; set; }
        public string  Country { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
