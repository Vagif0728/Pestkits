using Petkit.Models;

namespace Petkit.ViewModels
{
    public class HomeVM
    {   
        public List<Blog> Blogs { get; set; }
        public List<Employee> Employees { get; set; }

        public List<Department> Department { get; set; }
        public List<Position> Positions { get; set; }
        public List<Author> Author { get; set; }
        
    }
}
