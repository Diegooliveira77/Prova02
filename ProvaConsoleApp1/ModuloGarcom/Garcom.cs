using ProvaConsoleApp1.ModuloCOmpartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaConsoleApp1.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {
        static private int id = 0;

        public string Nome { get; set; }

        public int Idade { get; set; }

        public Garcom()
        {
            ObterId(ref id);
        }

        public Garcom(int id)
        {
            Id = id;
        }

        public override string[] ObterAtributos()
        {
            string[] atributos = { (Id + ""), Nome,  };
            return atributos;
        }

        public override void Atualizar(EntidadeBase entidade)
        {
            Garcom garcon = (Garcom)entidade;
            Nome = garcon.Nome;
           
        }

        public override ArrayList ObterErros()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(Nome.Trim()))
            {
                erros.Add("O campo nome é obrigatório");
            }

            if (Idade < 0)
            {
                erros.Add("O campo idade não pode ser menor que 0");
            }

            return erros;
        }

        public override EntidadeBase ObterNovaInstancia()
        {
            return new Garcom(Id);
        }

    }
}