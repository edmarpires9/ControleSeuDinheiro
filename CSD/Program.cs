/*Meu GitHub */
using CSD.Common.Models;
using System.Collections; 

string opcao;
bool exibirMenu = true;

Dinheiro dinheiro = new Dinheiro();

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("CSD - CONTROLE SEU DINHEIRO");
    Console.WriteLine("1. ADICIONAR SALDO");
    Console.WriteLine("2. REMOVER SALDO");
    Console.WriteLine("3. FECHAR APLICATIVO");
    dinheiro.exibirDinheiro();

    opcao = Console.ReadLine();


    switch(opcao)
    {
        case "1":
        dinheiro.adicionarDinheiro(Convert.ToDouble(Console.ReadLine()));
        break;
        
        case "2":
        dinheiro.removerDinheiro(Convert.ToDouble(Console.ReadLine()));
        break;
        
        case "3":
        exibirMenu = false;
        break;
    }
}