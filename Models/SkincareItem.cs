using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bellusBibliotheca2.Models
{
    public class SkincareItem
    {
        [Key]
        public int Serial { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        
        public ICollection<StylingTool> StylingTools { get; set; }
        public string Slug => Name.Replace('_', ' ');
        public DateTime ExpirationDate { get; set; } = DateTime.Now;
    }
}
