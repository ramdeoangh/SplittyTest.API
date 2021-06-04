using System.ComponentModel.DataAnnotations;

namespace SplittyTest.API.Resources
{
    public class RequestCategory
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}