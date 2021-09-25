using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Extensoes;
using ByteBank.SistemaAgencia.Comparadores;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(231, 67687),
                new ContaCorrente(233, 78567),
                new ContaCorrente(276, 43423),
                new ContaCorrente(953, 43232),

            };

            //contas.Sort();

            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            IOrderedEnumerable<ContaCorrente> contasOrdenadas =  
                contas.OrderBy(conta => {
                    if(conta == null)
                    {
                        return int.MaxValue;
                    }

                    return conta.Numero;
                });

            foreach (var conta in contasOrdenadas)       
            {
                if( conta != null)
                {
                    Console.WriteLine($"Conta número{conta.Numero}, ag. {conta.Agencia}");
                }
                
            }

            
        }

        static void TestaSort()
        {

             var nomes = new List<string>()
            {
                "Guilherme",
                "Luana",
                "Wellington",
                "Ana"
            };
            
            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine($"{nome}");
            }

            Console.ReadLine();

            var idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            //ListExtensoes.AdicionarVarios(idades, 2, 1, 3);

            idades.AdicionarVarios(45, 89, 12);

            idades.AdicionarVarios(99, -1);

            idades.Sort();

            for(int i = 0; i < idades.Count; i++)
            {
                int idadeAtual = idades[i];
                Console.WriteLine(idadeAtual);
            }

        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach(int numero in numeros)
            {
                acumulador += numero;
            }

            return acumulador;
        }

        static void TestaListaDeContaCorrente()
        {
             Console.WriteLine(SomarVarios(1, 2, 3, 5, 34525, 4));

            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoVini = new ContaCorrente(111, 111111);

            ContaCorrente[] contas = new ContaCorrente[]
                {
                    contaDoVini,
                    new ContaCorrente(345, 464657),
                    new ContaCorrente(576, 786766)
                };
            
            lista.AdicionarVarios(contas);
            lista.AdicionarVarios(
                contaDoVini,
                new ContaCorrente(874, 98459354));

            for(int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Agencia} / {itemAtual.Numero}");
            }
            
            Console.ReadLine();
        }

        static void TesteArrayContaCorrente()
        {

            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(213, 133132),
                    new ContaCorrente(345, 464657),
                    new ContaCorrente(576, 786766)
                };
   

            for(int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contas[indice].Numero}");
            }
        }

        static void TestaArrayInt()
        {

            int[] idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            // idades[3] = 50;
            // idades[4] = 28;
            // idades[5] = 60;

            int acumulador = 0;
            for(int indice = 0; indice <= idades.Length - 1; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador/idades.Length;

            Console.WriteLine($"Média de idades = {media}");
        }
    }
}
