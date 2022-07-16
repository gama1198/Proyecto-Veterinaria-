using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vet.Models;
using Vet.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Vet.Controllers
{
    public class MascotaController : Controller
    {
        public IActionResult Index(string TipoMascota, string Nombre_Mascota)
        {
            MascotaViewModel viewModel = new MascotaViewModel();
            if (TipoMascota != null && Nombre_Mascota != null)
            {
                viewModel.mascotas = DataMock.mascotas.Where(f => f.ID_Type.Equals(TipoMascota) && f.Name.Equals(Nombre_Mascota)).ToList();
            }
            else
            {
                if (TipoMascota == null && Nombre_Mascota == null)
                {
                    viewModel.mascotas = DataMock.mascotas;
                }
                else
                {
                    if (TipoMascota != null)
                    {
                        viewModel.mascotas = DataMock.mascotas.Where(f => f.ID_Type.Equals(TipoMascota)).ToList();
                    }

                    if (Nombre_Mascota != null)
                    {
                        viewModel.mascotas = DataMock.mascotas.Where(f => f.Name.Equals(Nombre_Mascota)).ToList();
                    }
                }
            }
            viewModel.MascotaCount = DataMock.mascotas.Count;

            viewModel.tipoMascotas = tipomascota.tipoMascota.ToList();

            ViewData["TipoMascota"] = new SelectList(viewModel.tipoMascotas);


            return View(viewModel);
        }
        public IActionResult Create()
        {
            TipoMascotaViewModel viewModel = new TipoMascotaViewModel();
            viewModel.tipomascota = tipomascota.tipoMascota.ToList();

            ViewData["TipoMascota"] = new SelectList(viewModel.tipomascota);

            return View();
        }
        [HttpPost]
        public IActionResult Create(int Id_Mascota, DateTime Fecha, string Nombre_Mascota, DateTime FechaNacimiento, string TipoMascota, string NombreDueño, string Telefono)
        {
            int index = DataMock.mascotas.Count + 1;
            DataMock.mascotas.Add(new PetFiles()
            {
                ID = index,
                CreationDate = Fecha,
                Name = Nombre_Mascota,
                BrithdayDate = FechaNacimiento,
                ID_Type = TipoMascota,
                OwnerName = NombreDueño,
                OwnerPhone = Telefono
            });
            return View();
        }

        public IActionResult Check(int Id_Mascota)
        {
            MascotaViewModel viewModel = new MascotaViewModel();

            viewModel.mascotas = DataMock.mascotas;

            viewModel.mascotas = DataMock.mascotas.Where(f => f.ID.Equals(Id_Mascota)).ToList();

            return View(viewModel);
        }
    }
}