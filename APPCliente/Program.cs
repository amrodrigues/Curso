﻿using Repositorio;
using System.Diagnostics;
using System.Globalization;

namespace AppClientes;

class Program
{
    static ClienteRepositorio _clienteRepositorio = new ClienteRepositorio();
    static void Main(String[] args)
    {
        // Caso não esteja em Português
        //var cultura = new CultureInfo("pt-BR");
        //Thread.CurrentThread.CurrentCulture = cultura;
        //Thread.CurrentThread.CurrentCulture = cultura;

        _clienteRepositorio.LerDadosClientes();
        while (true)
        { 
        Menu(); 

        Console.ReadKey();

        }
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine(" Cadastro de Clientes");
        Console.WriteLine("----------------------");
        Console.WriteLine("1 - Cadastrar Clientes");
        Console.WriteLine("2 - Exibir Clientes");
        Console.WriteLine("3 - Editar Clientes");
        Console.WriteLine("4 - Excluir Clientes");
        Console.WriteLine("5 - Sair");

        EscolherOpcao();
    }

    static void EscolherOpcao()
    {
        Console.WriteLine("Escolha uma opção:");

        var opcao = Console.ReadLine();

        switch (int.Parse(opcao))
        {
            case 1:
                {
                    _clienteRepositorio.CadastrarCliente();
                    Menu();
                    break;
                }
            case 2:
                {
                    _clienteRepositorio.ExibirClientes();
                    Menu();
                    break;
                }
            case 3:
                {
                    _clienteRepositorio.EditarCliente();
                    Menu();
                    break;
                }
            case 4:
                {
                    _clienteRepositorio.ExcluirCliente();
                    Menu();
                    break;
                }

                case 5:
                {
                    _clienteRepositorio.GravarDadosClientes();
                    Environment.Exit(0);
                    break;

                }
            default:
                {
                    Console.Clear();
                    Console.WriteLine("Opção Inválida");
                    break;
                }
        }
    }
}