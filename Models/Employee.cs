using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace suggestionspa.Models
{
    [Table("Employees")]
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Gender Gender { get; set; } 
        public int GenderId { get; set; }        
    }
}