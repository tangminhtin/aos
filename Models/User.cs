using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Shop.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            WarehouseDetails = new HashSet<WarehouseDetail>();
            Warehouses = new HashSet<Warehouse>();
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Email.")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Email is Wrong format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter Password.")]
      
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter Name.")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Name is Wrong format")]
        [StringLength(maximumLength: 25, MinimumLength = 2, ErrorMessage = "Name is Wrong format")]
        public string Fullname { get; set; }

        [Required]
        [RegularExpression(@"^(\+84|0[3|5|7|8|9])+([0-9]{8})", ErrorMessage = "Phone is Wrong format")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter Address.")]
        [RegularExpression(@"^[a-zA-Z0-9 -,]+$", ErrorMessage = "Address is Wrong format")]
        [StringLength(maximumLength:200, MinimumLength = 10, ErrorMessage = "Address must be more detail")]
        public string Address { get; set; }
        public int Status { get; set; }
        public string RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
        public virtual ICollection<WarehouseDetail>? WarehouseDetails { get; set; }
        public virtual ICollection<Warehouse>? Warehouses { get; set; }
    }
}
