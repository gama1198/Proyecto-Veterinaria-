using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;




namespace Vet.Models
{
    public class Types
    {
        [Key]
        public int ID { get; set; } 
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }   

 
        public ICollection<PetFiles> PetFile { get; set; } 


    }
}
