using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Data.Customers
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public int? Privilege { get; set; }

    }
}
