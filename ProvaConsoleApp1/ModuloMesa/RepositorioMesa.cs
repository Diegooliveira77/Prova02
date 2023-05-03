using ProvaConsoleApp1.ModuloCOmpartilhado;
using ProvaConsoleApp1.ModuloMesa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaConsoleApp1.ModuloMesa
{
    internal class RepositorioMesa : RepositorioBase
    {
        public RepositorioMesa()
        {

        }

        public override Mesa EncontrarRegistro(int id)
        {
            return (Mesa)base.EncontrarRegistro(id);
        }
    }
}