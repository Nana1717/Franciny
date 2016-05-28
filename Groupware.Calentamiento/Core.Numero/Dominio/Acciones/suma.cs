using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Acciones
{
    class suma
    {
        public double Operar (Numero elPrimerNumero, Numero elSegundoNumero)
        {
            Numero resultado;
            var validarBase = new Validaciones.ValidarBase();
            if (validarBase.LasDosBasesSonIguales(elPrimerNumero, elSegundoNumero))
            {
                double elResultadoNumerico = (elPrimerNumero.elNumeroEnDecimal + elSegundoNumero.elNumeroEnDecimal)

                   //Todo: convetir el resultado en base 10 del punto anterior a la base de los numeros
                   // por ejemplo, originamente, podria estar sumando "2a"
                  
                resultado = new Numero(elPrimerNumero.elNumeroEnDecimal + elSegundoNumero.elNumeroEnDecimal);
            }
            return (resultado);
                }
    }
}
