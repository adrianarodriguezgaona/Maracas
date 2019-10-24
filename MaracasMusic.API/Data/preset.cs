using Maracas.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Data
{

    // klasse gemaakt voor gemakkelijk te kunnen push'n en pull'n wanneer we even in hetzelfde document moeten werken.

    public class preset : DbContext
    {


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

            new Product
            {
                Id = 17,
                ProductTypeId = 2,
                Price = 60,
                Description = "Finish: Natural - Siam Oak drum shell with natural head - Head: Ø 4.5' - Approx. 28 cm high - Mini Comfort Curve II Rims",
                Foto = "instrumentPerc1.jpg"
            };

            new Product
            {
                Id = 18,
                ProductTypeId = 2,
                Price = 20,
                Description = "Simple wooden percussion instrument, deliverd in pairs",
                Foto = "instrumentPerc2.jpg"
            };
            
            new Product
            {
                Id = 19,
                ProductTypeId = 2,
                Price = 0 ,
                Description = "",
                Foto = "instrumentString1.jpg"

            };

                  new Product
                  {
                      Id = 20,
                      ProductTypeId = 2,
                      Price = 470,
                      Description = "RoseWood back, glossy finish, hand crafted",
                      Foto = "instrumentString2.jpg"
                  };

           new Product
           {
               Id = 21,
               ProductTypeId = 2,
               Price = 20,
               Description = "Hand crafted, made of Bamboo, pure tuning",
               Foto = "instrumentWind1"
           };

            new Product
            {
                Id = 22,
                ProductTypeId = 2,
                Price = 45,
                Description = "Hand crafted, made of plum wood",
                Foto = "instrumentWind2"
            };

            new Product
            {
                Id = 23,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Shakira sheet music - Song: Whenever, Wherever",
                Foto = "scoreSha1.jpg"

            };

            new Product
            {
                Id = 24,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Shakira sheet music - Song: Hips don't Lie",
                Foto = "scoreSha2.jpg"


            };

            new Product
            {
                Id = 25,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Juanes sheet music - Song: La Camisa Negra",
                Foto = "scoreJua1.jpg"

            };

            new Product
            {
                Id = 26,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Juanes sheet music - Song: Juentos",
                Foto = "scoreJua2.jpg"

            };

            new Product
            {
                Id = 27,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Marc Anthony sheet music - Song: Vivir mi Vida",
                Foto = "scoreMar1.jpg"

            };

            new Product
            {
                Id = 28,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Marc Anthony sheet music - Song: Te Conozco Bien",
                Foto = "scoreMar2.jpg"

            };

            new Product
            {
                Id = 29,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Grupo Niche sheet music - Song: Tapanco El Hueco",
                Foto = "scoreGru1.jpg"


            };

            new Product
            {
                Id = 30,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Grupo Niche - Song: El Amor Vendra",
                Foto = "scoreGru2.jpg"

            };

        

        new Product
            {
                Id = 31,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Maluma sheet music - Song: Felices los 4",
                Foto = "scoreMal1.jpg"

            };

            new Product
            {
                Id = 32,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Maluma sheet music - Song: Corazòn",
                Foto = "scoreMal2.jpg"

            };

            new Product
            {
                Id = 33,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Chino y Nacho sheet music - Song: Andas en mi Cabeza",
                Foto = "scoreChi1.jpg"

            };

            new Product
            {
                Id = 34,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Chino y Nacho sheet music - Song: Mi Niña Bonita",
                Foto = "scoreChi2.jpg"

            };

            new Product
            {
                Id = 35,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Carlos Vives - Song: Déjame Entrar",
                Foto = "scoreCar1.jpg"

            };

            new Product
            {
                Id = 36,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Carlos Vives sheet music - Song: Carito",
                Foto = "scoreCar2.jpg"

            };

            new Product
            {
                Id = 37,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Elvis Crespo sheet music - Song: Suavemente",
                Foto = "scoreElv1.jpg"

            };

            new Product
            {
                Id = 38,
                ProductTypeId = 3,
                Price = 9.99m,
                Description = "Elvis Crespo sheet music - Song: Pintame",
                Foto = "scoreElv2.jpg"

            };

          




        }
            
            




        }
}
