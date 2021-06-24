using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "You need to keep the name to a max of 20 characters")]
        [MinLength(3, ErrorMessage = "You need to keep the name to a min of 3 characters")]
        [DisplayName("Name for the Order")]
        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        [DisplayName("Meal")]
        [Range(1, int.MaxValue, ErrorMessage ="You need to select  a meal from the list")]
        public int FoodId { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage="You can select up to ten meals")]
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
