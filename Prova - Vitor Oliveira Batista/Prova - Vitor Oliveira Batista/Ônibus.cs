using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova___Vitor_Oliveira_Batista
{
    public class Ônibus : Veiculo
    {
        public int assentos;

        public Ônibus(string placa, int ano, int assentos):base(placa,ano)
        {
            this.assentos = assentos;
        }

        public override double Alugar()
        {
            return (30 * assentos) - (2025 - ano) * 70;
        }

        public string getPlaca()
        {
            return this.placa;
        }


    }
}
