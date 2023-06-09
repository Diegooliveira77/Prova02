﻿using ProvaConsoleApp1.ModuloCOmpartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaConsoleApp1.ModuloGarcom
{
    public class TelaGarcom : TelaBase
    {


        public TelaGarcom(RepositorioBase repositorio) : base(repositorio)
        {
            titulo = "Garçons";
            nomeEntidade = "Garçom";
            string[] cabecalho = { "Id:", "Nome:", "Idade:" };
            Cabecalho = cabecalho;
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
                        Console.WriteLine("Garçom registrado!");
                        Console.ReadLine();
                        break;
                    case "2":
                        MostrarEntidades();
                        Console.ReadLine();
                        break;
                    case "3":
                        if (repositorio.Lista.Count <= 0)
                        {
                            Console.WriteLine("Não existe garçons registrados no sistema!");
                            Console.ReadLine();
                            return;
                        }
                        AtualizarEntidade();
                        Console.WriteLine("Garçom atualizado!");
                        Console.ReadLine();
                        break;
                    case "4":
                        if (repositorio.Lista.Count <= 0)
                        {
                            Console.WriteLine("Não existe garçons registrados no sistema!");
                            Console.ReadLine();
                            return;
                        }
                        RemoverEntidade();
                        Console.WriteLine("Garçom removido!");
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
            Garcom garcom = new Garcom();
            PreencherAtributos(garcom);
            return garcom;
        }

        public override void PreencherAtributos(EntidadeBase entidade)
        {
            bool entidadeValida = false;
            while (!entidadeValida)
            {
                Garcom garcom = (Garcom)entidade;
                Console.Write("Digite o nome do garçom: ");
                string nome = Console.ReadLine();
                garcom.Nome = nome;
                int idade = ValidarInt("Digite a idade do garçom: ");
                garcom.Idade = idade;
                entidadeValida = ValidarEntidade(garcom);
            }
        }
    }
}
