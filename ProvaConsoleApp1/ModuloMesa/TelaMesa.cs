﻿using ProvaConsoleApp1.ModuloCOmpartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaConsoleApp1.ModuloMesa
{
    internal class TelaMesa : TelaBase
    {


        public TelaMesa(RepositorioBase repositorio) : base(repositorio)
        {
            titulo = "Mesas";
            nomeEntidade = "Mesa";
           
        }

        public void Opcoes()
        {
            while (true)
            {
                MostrarMenu();
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "0":
                        return;
                    case "1":
                        repositorio.InserirRegistro(RegistrarEntidade());
                        Console.WriteLine("Mesa registrada!");
                        Console.ReadLine();
                        break;
                    case "2":
                        MostrarEntidades();
                        Console.ReadLine();
                        break;
                    case "3":
                        if (repositorio.Lista.Count <= 0)
                        {
                            Console.WriteLine("Não existe mesas registradas no sistema!");
                            Console.ReadLine();
                            return;
                        }
                        AtualizarEntidade();
                        Console.WriteLine("Mesa atualizada!");
                        Console.ReadLine();
                        break;
                    case "4":
                        if (repositorio.Lista.Count <= 0)
                        {
                            Console.WriteLine("Não existe mesas registradas no sistema!");
                            Console.ReadLine();
                            return;
                        }
                        RemoverEntidade();
                        Console.WriteLine("Mesa removida!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Opção não encontrada!");
                        Console.ReadLine();
                        break;
                }
            }
        }

        public override EntidadeBase RegistrarEntidade()
        {
            Mesa mesa = new Mesa();
            PreencherAtributos(mesa);
            return mesa;
        }

        public override void PreencherAtributos(EntidadeBase entidade)
        {
            bool entidadeValida = false;
            while (!entidadeValida)
            {
                Mesa mesa = (Mesa)entidade;
                int numero = ValidarInt("Digite o número da mesa: ");
                mesa.Numero = numero;
                Console.Write("Digite o tipo da mesa: ");
                string tipo = Console.ReadLine();
                mesa.Tipo = tipo;
                entidadeValida = ValidarEntidade(mesa);
            }
        }
    }
}