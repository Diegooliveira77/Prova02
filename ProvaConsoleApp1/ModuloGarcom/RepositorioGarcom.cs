using ProvaConsoleApp1.ModuloCOmpartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaConsoleApp1.ModuloGarcom
{
  public class RepositorioGarcom : RepositorioBase
    {
        public RepositorioGarcom()
        {

        }

        public override Garcom EncontrarRegistro(int id)
        {
            return (Garcom)base.EncontrarRegistro(id);
        }
    }
}