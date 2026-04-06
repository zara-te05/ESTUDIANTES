namespace Business
{
    public class Register
    {
        private readonly IValidate _validate;

        public Register(IValidate validate)
        {
            _validate = validate;
        }

        public void Add(string nombre_completo, int edad, string nombre_escuela)
        {
            if (_validate.(nombre_completo, edad, nombre_escuela))
            {

            }
        }

    }
}
