using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecordingOfViolations.Models
{
    public class PaymentСheck
    {
        public int PaymentСheckId { get; set; }

        [Required(ErrorMessage = "Please enter a payment type")]
        public string PaymentType { get; set; } = String.Empty;

        [Required(ErrorMessage = "Please enter a payer")]
        public string Payer { get; set; } = String.Empty; //платик

        public DateTime Date { get; set; } = DateTime.Now;
        public int ViolationId { get; set; }
}
}
