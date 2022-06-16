using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automovel
{
    internal class AutomovelLuxo : Automovel
    {
        public bool direcaoHidraulica;
        public bool arCondicionado;
        public bool vidrosEletricos;
        public bool computadorDeBordo = true;

        public AutomovelLuxo(string placa, string modelo, byte combustivel, string cor, int ano, bool direcaoHidraulica, bool arCondicionado, bool vidrosEletricos) : base(placa, modelo, combustivel, cor, ano)
        {
            this.direcaoHidraulica = direcaoHidraulica;
            this.arCondicionado = arCondicionado;
            this.vidrosEletricos = vidrosEletricos;
        }

        public override double calcularPreco(byte combustivel)
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

            if (direcaoHidraulica)
                precoFinal += 1500.00;
            if (arCondicionado)
                precoFinal += 2000.00;
            if (vidrosEletricos)
                precoFinal += 800.00;

            return precoFinal;
        }
    }
}
