using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace suggestionspa.Models
{
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }

        public Gender()
        {
            Employees = new Collection<Employee>();
        }
    }
}