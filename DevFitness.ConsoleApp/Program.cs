using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFitness.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite sua altura");
            var altura = Console.ReadLine();

            Console.WriteLine("Digite seu peso");
            var peso = Console.ReadLine();

            var listaRefeicao = new List<Refeicao>();

            var opcao = "-1";
            while (opcao != "0")
            {
                ExibirOpcoes();
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine($"Nome: {nome}, Altura: {altura}, Peso: {peso}");
                        break;
                    case "2":
                        var refeicoes = Cadastrar();
                        foreach (var refeicao in refeicoes)
                        {
                            listaRefeicao.Add(refeicao);
                        }
                        break;
                    case "3":
                        ListarRefeicoes(listaRefeicao);
                        break;
                    default:
                        Console.WriteLine("Por favor escolha outra opção.");
                        break;
                }
            }


            Console.WriteLine("Fechando Aplicação");
            Console.Read();
        }

        public static void ExibirOpcoes()
        {
            Console.WriteLine("--- Seja bem-vindo (a) ao DevFitness ---");
            Console.WriteLine("1- Exibir detalhes de usuario.");
            Console.WriteLine("2- Cadastrar nova refeição.");
            Console.WriteLine("3- Listar todas refeições. ");
            Console.WriteLine("0- Finalizar aplicação. ");
        }
        public static List<Refeicao> Cadastrar()
        {
            var refeicao = new Refeicao();
            var refeicoes = new List<Refeicao>();
            var tipo = "0";

            while (tipo != "1" || tipo != "2" || tipo != "0")
            {
                Console.WriteLine("Informe o tipo de refeição :");
                Console.WriteLine("1 - Comida ");
                Console.WriteLine("2 - Bebida ");
                Console.WriteLine("0 - Retornar ");
                var tipoRefeicao = Console.ReadLine();
                switch (tipoRefeicao)
                {
                    case "1":
                        refeicao = CriarComida();
                        refeicoes.Add(refeicao);
                        break;
                    case "2":
                        refeicao =  CriarBebida();
                        refeicoes.Add(refeicao);
                        break;
                    case "0":
                        return refeicoes;

                    default:
                        Console.WriteLine("Favor insira um opção valida");
                        break;
                }
            }

           
            return refeicoes;
        }
        public static void ListarRefeicoes(List<Refeicao> refeicoes)
        {
            foreach (var refeicao in refeicoes)
            {
                refeicao.ImprimirMensagem();
            }
        }
        public static Comida CriarComida()
        {
            var comida = new Comida();
            var cadastrado = false;

            while (!cadastrado)
            {
                Console.WriteLine("Digite a descricao da refeição. ");
                var descricao = Console.ReadLine();
                Console.WriteLine("Digite a quantidade de calorias. ");
                var calorias = Console.ReadLine();
                Console.WriteLine("Digite o preco");
                var valor = Console.ReadLine();

                if (int.TryParse(calorias, out int caloriasInt) && decimal.TryParse(valor, out decimal preco))
                {
                    comida = new Comida(descricao, caloriasInt, preco);

                    Console.WriteLine("Comida adicionada com sucesso");
                    cadastrado = true;
                }
                else
                {
                    Console.WriteLine("Valor de calorias e/ou preço inválido. Tente novamente! ");
                }
            }

            return comida;
        }
        public static Bebida CriarBebida()
        {
            var bebida = new Bebida();
            var cadastrado = false;

            while (!cadastrado)
            {
                Console.WriteLine("Digite a descricao da bebida. ");
                var descricao = Console.ReadLine();
                Console.WriteLine("Digite a quantidade de calorias. ");
                var calorias = Console.ReadLine();
                Console.WriteLine("Bebida contém lactose? ");
                var lactose = Console.ReadLine();
                bool contemLactose = lactose.ToLower().Equals("sim") ? true : false;
                if (int.TryParse(calorias, out int caloriasInt))
                {
                    bebida = new Bebida(descricao, caloriasInt, contemLactose);

                    Console.WriteLine("Comida adicionada com sucesso");
                    cadastrado = true;
                }
                else
                {
                    Console.WriteLine("Valor de calorias e/ou preço inválido. Tente novamente! ");
                }
            }

            return bebida;
        }
    }
}
