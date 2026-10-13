using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace GadgetInventory.Models
{
    public class Gadget
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Brand name is reuqired.")]
        public string Brand { get; set;}
 
        [Required(ErrorMessage = " Model name is required")]
        [Display(Name = "Model Name")]
        public string ModelName { get; set;}

        [Range(1 , 5000, ErrorMessage = "Pirce must be betweeen $1 and $5000.")]
        public decimal Price { get; set; }
    }
}
