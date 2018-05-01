using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace suggestionspa.Models
{
    public class Gender
    {
        public int Id { get; set; }
        
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }

        public Gender()
        {
            Employees = new Collection<Employee>();
        }
    }
}