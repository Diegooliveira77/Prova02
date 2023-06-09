﻿using ProvaConsoleApp1.ModuloCOmpartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaConsoleApp1.ModuloConta
{
   public class RepositorioConta : RepositorioBase
    {
            public ArrayList ListaFechada { get; set; }

            public RepositorioConta()
            {
                this.ListaFechada = new ArrayList();
            }

            public override Conta EncontrarRegistro(int id)
            {
                return (Conta)base.EncontrarRegistro(id);
            }

            public void FecharConta(Conta conta)
            {
                ListaFechada.Add(conta);
                Lista.Remove(conta);
            }

            public void InserirContaPedido(Conta conta, Pedido pedido)
            {
                conta.PedidosLista.Add(pedido);
            }

            public void RemoverContaPedido(Conta conta, Pedido pedido)
            {
                conta.PedidosLista.Remove(pedido);
            }

            public void EditarPedido(
               Pedido pedido, Pedido pedidoAtualizado
           )
            {
                pedido.Atualizar(pedidoAtualizado);
            }

            public double ObterFaturamentoDia(DateTime data)
            {
                double soma = 0;
                DateTime hoje = data;
                foreach (Conta conta in ListaFechada)
                {
                    if (
                        hoje == conta.DataFechamento
                    )
                    {
                        soma += conta.TotalConta;
                    }
                }
                return soma;
            }
        }
    }