using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Validaciones
{
    public class ValidarNumero
    {
        public bool ElNumeroEsValidoEnlaBase (string elNumero, int laBase)
        {
            bool elResultado = true ;
            for (int i = 0; (elResultado == true ) & ( i < elNumero.Length);i++)
            {
                elResultado = ElDigitoEsValidoEnlaBase(elNumero[i], laBase);
            }
            return (elResultado);
        }

        private bool ElDigitoEsValidoEnlaBase (char elDigito, int laBase)
        {
            bool elResultado;
            // Todo: Verificarlo!!
            elResultado = true;
            return (elResultado);
        }
    }
}
