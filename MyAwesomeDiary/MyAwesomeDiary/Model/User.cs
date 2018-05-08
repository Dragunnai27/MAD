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
        public string Pass { get; set; }
        [StringLength(20, ErrorMessage = "invalid int",MinimumLength = 5)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
    }
}
