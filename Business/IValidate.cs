using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business
{
    public class IValidate
    {
        public void Save(string nombre_completo, int edad, string nombre_escuela)
        {
            if(edad == null)
            {
                throw new ArgumentException("La edad no puede ser nula");
            }
            if(edad < 18)
            {
                throw new ArgumentException("Se necesita ser mayor de 18 años");
            }
            if(nombre_completo is not { Length: > 0 })
            {
                throw new ArgumentException("Se requiere de un nombre para el registro");
            }
        }
    }
}
