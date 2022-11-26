using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades___Metodos___Construtores.Models
{
    public static class Extensions
    {
        /// <summary>
        /// Retorna um boolean se o valor é multiplo do divisor enviado por parâmetro.
        /// </summary>
        /// <param name="value">Inteiro que será o divisor da operação.</param>
        /// <param name="verifier">Inteiro que será o dividendo.</param>
        /// <returns></returns>
        public static bool VerifyMultiple(this int value, int verifier)
        {
            return value % verifier == 0;
        }
    }
}
