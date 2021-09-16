using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoVini = new ContaCorrente(111, 111111);

            lista.Adicionar(contaDoVini);



            lista.Adicionar(new ContaCorrente(123, 1231312));
            lista.Adicionar(new ContaCorrente(456, 8348049));
            lista.Adicionar(new ContaCorrente(654, 8948433));
            lista.Adicionar(new ContaCorrente(654, 8948433));
            lista.Adicionar(new ContaCorrente(654, 8948433));
            lista.Adicionar(new ContaCorrente(654, 8948433));
            lista.Adicionar(new ContaCorrente(654, 8948433));
            lista.Adicionar(new ContaCorrente(654, 8948433));
            lista.Adicionar(new ContaCorrente(654, 8948433));
            lista.Adicionar(new ContaCorrente(654, 8948433));
            lista.Adicionar(new ContaCorrente(654, 8948433));


            lista.EscreverListaNaTela();

            lista.Remover(contaDoVini);

            Console.WriteLine("Após remover o item");

            lista.EscreverListaNaTela();

            
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
