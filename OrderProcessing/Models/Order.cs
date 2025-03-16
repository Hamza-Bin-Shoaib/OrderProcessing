using System.ComponentModel.DataAnnotations;

namespace OrderProccessing.Models
{
    public class Order
    {
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Order amount must be greater than zero.")]
        public decimal Amount { get; set; }

        [Required]
        public string? CustomerType { get; set; }

        public decimal Discount { get; set; }
        public decimal FinalTotal => Amount - Discount;

        public void CalculateDiscount()
        {
            if (Amount >= 100 && CustomerType == "Loyal")
            {
                Discount = Amount * 0.10m; 
            }
            else
            {
                Discount = 0;
            }
        }
    }


}

