using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        // data annotation for defining a field as primary key
        // [Key] // this indicates that below propertry is the primary key of the table
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }


        public int DisplayOrder { get; set; }


    }

}
