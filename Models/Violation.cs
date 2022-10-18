using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecordingOfViolations.Models
{
    public class Violation
    {
        public int ViolationId { get; set; }

        [Required(ErrorMessage = "Please enter a reason")]
        public string Reason { get; set; } = String.Empty;

        [Required(ErrorMessage = "Please enter an address")]
        public string Address { get; set; } = String.Empty;

        [Required(ErrorMessage = "Please enter a policeman")]
        public string Policeman { get; set; } = String.Empty;

        [Required(ErrorMessage = "Please enter an offender")]
        public string Offender { get; set; } = String.Empty;//порушник

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
