﻿using ProvaConsoleApp1.ModuloCOmpartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaConsoleApp1.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        static private int id = 0;


        public int Numero { get; set; }

        public string Tipo { get; set; }

        public Mesa()
        {
            ObterId(ref id);
        }

        public Mesa(int id)
        {
            Id = id;
        }

        public override string[] ObterAtributos()
        {
            string[] atributos = { (Id + ""), (Numero + ""), Tipo };
            return atributos;
        }

        public override void Atualizar(EntidadeBase entidade)
        {
            Mesa mesa = (Mesa)entidade;
            Numero = mesa.Numero;
            Tipo = mesa.Tipo;
        }

        public override ArrayList ObterErros()
        {
            ArrayList erros = new ArrayList();

            if (Numero < 0)
            {
                erros.Add("O campo número não pode ser menor que 0");
            }

            if (string.IsNullOrEmpty(Tipo.Trim()))
            {
                erros.Add("O campo tipo é obrigatório");
            }

            return erros;
        }

        public override Mesa ObterNovaInstancia()
        {
            return new Mesa(Id);
        }

    }
}