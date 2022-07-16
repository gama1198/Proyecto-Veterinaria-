using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vet.Models.ViewModels
{
    public class MascotaViewModel
    {
        public List<PetFiles> mascotas { get; set; }

        public int MascotaCount { get; set; }


        public List<string> tipoMascotas { get; set; }
    }
}
