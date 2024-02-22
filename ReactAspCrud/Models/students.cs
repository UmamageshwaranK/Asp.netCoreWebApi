using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ReactAspCrud.Models
{
    public class students
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; } 
    }
}
