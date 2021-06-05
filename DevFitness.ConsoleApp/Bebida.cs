using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFitness.ConsoleApp
{
    public class Bebida : Refeicao
    {
        public Bebida(string descricao, int calorias, bool contemLactose) : base(descricao, calorias)
        {
            ContemLactose = contemLactose;
        }

        public Bebida() : base()
        {
        }

        public bool ContemLactose { get; private set; }
        public override void ImprimirMensagem()
        {
            var contemLactose = ContemLactose == true ? "Sim" : "Não";
            Console.WriteLine($"{Descricao}, com {Calorias} calorias, contém lactose? {contemLactose}");
        }
    }
}
