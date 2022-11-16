
using System;
using System.Collections.Generic;
using System.Text;

namespace Videojuego
{
    class VideoJuego
    {
        public string Numero { get; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public int Unidades {get; set;}

        private static int accountNumberSeed = 1;

        private List<Transaction> allTransactions = new List<Transaction>();

        public VideoJuego(string nombre, decimal precio,int cantidadInicial)
        {
            this.Numero = accountNumberSeed.ToString();
            accountNumberSeed++;
            this.Nombre = nombre;
            this.Precio = precio;
            ComprarJuego(cantidadInicial, DateTime.Now, " cantidad");
        }

        public void ComprarJuego(int unidades, DateTime date, string note)
        {
            if (unidades <= 0) // Decimal
            {
                throw new ArgumentOutOfRangeException(nameof(unidades), "No puedes no comprar ningun juego");
            }
            var compra = new Transaction(unidades, date);
            allTransactions.Add(compra);
        }

        public void VenderJuego(int unidades, DateTime date, string note)
        {
            if (unidades <= 0) // Decimal
            {
                throw new ArgumentOutOfRangeException(nameof(unidades), "No puedes no comprar ningun juego");
            }
            if (Unidades - unidades < 0)
            {
                throw new InvalidOperationException("No hay suficientes unidades :(");
            }
            var venta = new Transaction(-unidades, date);
            allTransactions.Add(venta);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            decimal balance = 0;
            report.AppendLine("Cantidad\t\tNombre\t\tPrecio");
            foreach (var item in allTransactions)
            {
                balance += item.Unidades;
                report.AppendLine($"{item.Unidades}\t{this.Nombre}\t{this.Precio}");
            }

            return report.ToString();
        }
    }
}