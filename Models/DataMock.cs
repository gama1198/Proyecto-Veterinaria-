using System;
using System.Collections.Generic;

namespace Vet.Models
{
    public class DataMock
    {


        public static List<PetFiles> mascotas = new List<PetFiles>()
        {

            new PetFiles() {
                ID = 1,Name="Kayser",BrithdayDate = new DateTime(2022,03,01),ID_Type= TipoMascotas.Otro,OwnerName="Vicente Burgos",OwnerPhone="+5695874560", CreationDate=new DateTime(2022,06,08)
            },new PetFiles() {
                ID = 2,Name="Leon",BrithdayDate = new DateTime(2022,03,01),ID_Type= TipoMascotas.Conejo,OwnerName="Eva Luna",OwnerPhone="+56953645960", CreationDate=new DateTime(2022,06,08)
            },new PetFiles() {
                ID = 3,Name="Coyote",BrithdayDate = new DateTime(2022,03,01),ID_Type= TipoMascotas.Conejo,OwnerName="Roberto Alarcon",OwnerPhone="+56958747890", CreationDate=new DateTime(2022,06,08)
            },new PetFiles() {
                ID = 4,Name="Orejas",BrithdayDate = new DateTime(2022,03,01),ID_Type= TipoMascotas.Otro,OwnerName="Pedro Bravo",OwnerPhone="+56958712340", CreationDate=new DateTime(2022,06,08)
            },new PetFiles() {
                ID = 5,Name="Patas",BrithdayDate = new DateTime(2022,03,01),ID_Type= TipoMascotas.Gato,OwnerName="Mateo Quiriñao",OwnerPhone="+56958798760", CreationDate=new DateTime(2022,06,08)
            },new PetFiles() {
                ID = 6,Name="Andy",BrithdayDate = new DateTime(2022,03,01),ID_Type= TipoMascotas.Otro,OwnerName="Rodrigo Catril",OwnerPhone="+56958918260", CreationDate=new DateTime(2022,06,08)
            },new PetFiles() {
                ID = 7,Name="Tomas",BrithdayDate = new DateTime(2022,03,01),ID_Type= TipoMascotas.Tortuga,OwnerName="Julian Rodriguez",OwnerPhone="+56931159645", CreationDate=new DateTime(2022,06,08)
            },new PetFiles() {
                ID = 8,Name="Rodolfo",BrithdayDate = new DateTime(2022,03,01),ID_Type= TipoMascotas.Gato,OwnerName="Gael Cubillos",OwnerPhone="+56993459670", CreationDate=new DateTime(2022,06,08)
            },

        };
        public static bool AddMascotas(PetFiles mascota)
        {
            try
            {
                mascotas.Add(mascota);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
















}

