﻿using System;
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

            Lista<int> idades = new Lista<int>();

            idades.Adicionar(5);
            idades.AdicionarVarios(5, 2, 2);

            
            ListaDeObject  listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for(int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no índice {i} : {idade}");
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
