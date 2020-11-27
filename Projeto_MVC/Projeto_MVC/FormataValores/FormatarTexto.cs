using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC.FormataValores
{
    public class FormatarTexto
    {
        public static string FormataMaiusculo(string valor)
        {
            return valor.ToUpper().Trim();
        }

        public static string FormataMinusculo(string valor)
        {
            return valor.ToLower().Trim();
        }        
    }
}
