﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaConsoleApp1.ModuloCOmpartilhado
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }

        protected virtual void ObterId(ref int id)
        {
            id++;
            Id = id;
        }

        public abstract void Atualizar(EntidadeBase entidade);

        public abstract string[] ObterAtributos();

        public abstract ArrayList ObterErros();

        public abstract EntidadeBase ObterNovaInstancia();
    }
}
