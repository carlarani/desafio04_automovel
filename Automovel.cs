using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automovel
{
    class Automovel
    {
        public string placa;
        public string modelo;
        public byte combustivel;
        public string cor;
        public int ano;

        public const byte GASOLINA = 1;
        public const byte ALCOOL = 2;
        public const byte DIESEL = 3;
        public const byte GAS = 4;

        public static double precoFinal;

        public Automovel(string placa, string modelo, byte combustivel, string cor, int ano)
        {
            this.placa = placa;
            this.modelo = modelo;
            this.combustivel = combustivel;
            this.cor = cor;
            this.ano = ano;
        }

        public virtual double calcularPreco(byte combustivel)
        {
            switch (combustivel)
            {
                case 1: 
                    precoFinal = 12000.00;
                    break;
                case 2:
                    precoFinal = 10500.00;
                    break;
                case 3:
                    precoFinal = 11000.00;
                    break;
                case 4:
                    precoFinal = 13000.00;
                    break;
            }
            return precoFinal;
        }

    }
}
