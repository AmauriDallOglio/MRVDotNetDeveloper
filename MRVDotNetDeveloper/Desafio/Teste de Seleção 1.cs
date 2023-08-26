﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRVDotNetDeveloper.Desafio
{
    public class Teste_de_Seleção_1
    {
        public void resultado()
        {
            string[] selections = Console.ReadLine().Split(' ');
            int A = int.Parse(selections[0]);
            int B = int.Parse(selections[1]);
            int C = int.Parse(selections[2]);
            int D = int.Parse(selections[3]);

            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && (A % 2 == 0))
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}

/*
 * 
 * 
Desafio
Leia 4 valores inteiros A, B, C e D. Com base nisso, se o valor de B for maior do que de C e se D for maior do que A, e a soma de C com D for maior que a soma de A e B e se tanto C quanto D forem positivos e, ainda, se a variável A for par, escreva a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".

Entrada
Quatro números inteiros A, B, C e D.

Saída
Imprima a mensagem corretamente esperada pela validação dos valores.

 
Exemplo de Entrada	Exemplo de Saída
5 6 7 8

Valores nao aceitos

2 3 2 6	Valores aceitos
 * 
 */