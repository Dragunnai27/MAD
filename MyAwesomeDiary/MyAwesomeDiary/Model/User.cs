using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAwesomeDiary.Model
{
    public class User
    {
        [Key]
        public string UserId { get; set; }
        [Required]
        [MinLength(8)]
        public string Pass { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
