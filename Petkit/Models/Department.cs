namespace Petkit.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
