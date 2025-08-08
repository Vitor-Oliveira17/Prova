using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova___Vitor_Oliveira_Batista
{
    public class Caminhão : Veiculo
    {
        public int eixos;

        public Caminhão(string placa,int ano, int eixos):base(placa,ano){ 
            this.eixos= eixos;
        }

        public override double Alugar()
        {
            return (300 * eixos) - (2025 - ano) * 50;
        }

        public string getPlaca()
        {
            return this.placa;
        }

    }
}
