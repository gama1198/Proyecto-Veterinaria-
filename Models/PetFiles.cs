using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Vet.Models
{
    public class PetFiles
    {
        [Key]
       
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime BrithdayDate { get; set; }
        [Required]
        public string OwnerName { get; set; }
      
        [Required]
        public string OwnerPhone { get; set; }
        [Required]
        [MaxLength(50)]
        public DateTime CreationDate  { get; set; }
        [Required]
        [MaxLength(50)]
        public string ID_Type { get; set; }

        public Types Types { get; set; }    


    }


    public static class TipoMascotas
    {
        public const string Perro = "Perro", Gato = "Gato", Conejo = "Conejo", Tortuga = "Tortuga"
            , Hamster = "Hamster", Otro = "Otro";


    }
    public static class tipomascota
    {
        public static string[] tipoMascota = { "Perro", "Gato",
                "Conejo", "Tortuga","Hamster","Otro"
        };

    };


}

