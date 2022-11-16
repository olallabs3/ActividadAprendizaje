using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Videojuego
{
    class Program
    {
        private static List<VideoJuego> catalogo = new List<VideoJuego>();
       static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a NGB");

           try{

            var VideoJuego1 = new VideoJuego ("Apex Legends",10.99m,3);
            var VideoJuego2 = new VideoJuego ("Payaso Esponja Horror Horripilante Abuelita miedo",12m,100);
            var VideoJuego3 = new VideoJuego ("Crysis 2",30m,5);
            var VideoJuego4 = new VideoJuego ("Victoria 3",59.99m,10);

            catalogo.Add(VideoJuego1);
            catalogo.Add(VideoJuego2);
            catalogo.Add(VideoJuego3);
            catalogo.Add(VideoJuego4);

                foreach (var item in catalogo)
                {
                    Console.WriteLine(item);
                }

           }



            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("ArgumentOutOfRangeException: " + e.ToString());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("InvalidOperationException: " + e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.ToString());
            }

        }
    }
}
