using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova___Vitor_Oliveira_Batista
{
    public abstract class Veiculo
    {
        protected string placa;
        protected int ano;

        protected Veiculo(string placa, int ano)
        {
            this.ano = ano;
            this.placa = placa;
        }

        public abstract double Alugar();
    }
}
