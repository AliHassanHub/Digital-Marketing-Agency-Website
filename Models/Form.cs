using System.ComponentModel.DataAnnotations;

namespace Digital_Marketing_Agency.Models
{
    public class Form
    {
       public string fname { get; set; }
        [Key]
        public string email { get; set; }
        public string phone { get; set; }
        public string company { get; set; }
        public string package { get; set; }

    }
}
