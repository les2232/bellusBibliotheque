using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace bellusBibliotheca2.Models
{
    public class StylingTool
    {
        [Key]
        public int prodSerial { get; set; }
        [Required(ErrorMessage = "Please enter a serial number.")]
        public string BrandName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a last name.")]
        public string Type { get; set; } = string.Empty;
        public ICollection<StylingTool> Item { get; set; }
        public string FullName => BrandName + " " + prodSerial;   // read-only property
    }
}
