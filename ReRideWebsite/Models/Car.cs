using System.ComponentModel.DataAnnotations;

namespace ReRideWebsite.Models
{
    public class Car
    {



        //test
        [Key]
        public string Id{ get; set; }
        public string Name { get; set; }
        public string Model { get; set; } = "Test";
        public DateTime RegistrationDate { get; set; }


        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime ModifiedTime { get; set; } = DateTime.Now;

    }
}
