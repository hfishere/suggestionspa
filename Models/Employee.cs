using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace suggestionspa.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public Gender Gender { get; set; } 
        public int GenderId { get; set; }        
    }
}