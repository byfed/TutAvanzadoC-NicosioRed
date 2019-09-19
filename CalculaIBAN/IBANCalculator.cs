using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIBAN
{
    class IBANCalculator
    {
        private int _codigoBanco;
        private int _codigoSucursal;
        private int _digitoControl;
        private long _codigoCuenta;

        public IBANCalculator(string codigoBanco, string codigoSucursal, string digitoControl, string codigoCuenta)
        {
            if (String.IsNullOrEmpty(codigoBanco)) {
                throw new ArgumentNullException(codigoBanco, "El código de Banco no puede estar vacío o ser nulo") ;
            }

            if (String.IsNullOrEmpty(codigoSucursal))
            {
                throw new ArgumentNullException(codigoBanco, "El código de sucursal no puede estar vacío o ser nulo");
            }

            if (String.IsNullOrEmpty(digitoControl))
            {
                throw new ArgumentNullException(codigoBanco, "El digito de control no puede estar vacío o ser nulo");
            }

            if (String.IsNullOrEmpty(codigoCuenta))
            {
                throw new ArgumentNullException(codigoBanco, "El código de cuenta no puede estar vacío o ser nulo");
            }

            bool success = Int32.TryParse(codigoBanco, out this._codigoBanco);
            if (!success) throw new Exception("Código de banco no numérico");
            success = Int32.TryParse(codigoSucursal, out this._codigoSucursal);
            if (!success) throw new Exception("Código de sucursal no numérico");
            success = Int32.TryParse(digitoControl, out this._digitoControl);
            if (!success) throw new Exception("Dígitos de control no numérico");
            success = Int64.TryParse(codigoCuenta, out this._codigoCuenta);
            if (!success) throw new Exception("Código cuenta no numérico");

            if (digitosControlCalculator(_codigoBanco,_codigoSucursal,_codigoCuenta) != _digitoControl)
            {
                throw new Exception("Digitos de control erróneos");
            }

        }

        public int digitosControlCalculator (int codigoBanco, int codigoSucursal, long codigoCuenta)
        {
            int[] codBancoArray = extraeCifras(codigoBanco);
            int[] codSucursalArray = extraeCifras(codigoSucursal);
            int[] codCuentaArray = extraeCifras(codigoCuenta);
            int acumulator = 0;
            int resto;
            int digito1;
            int digito2;

            //Calculo de primer dígito
            //1. Se toman los cuatro digitos de la entidad y enumerando de izquierda a derecha:
            //La primera cifra de la entidad se multiplica por 4.
            //La segunda cifra de la entidad se multiplica por 8.
            //La tercera cifra de la entidad se multiplica por 5.
            //La cuarta cifra de la entidad se multiplica por 10.
            acumulator += codBancoArray[0] * 4;
            acumulator += codBancoArray[1] * 8;
            acumulator += codBancoArray[2] * 5;
            acumulator += codBancoArray[3] * 10;
            //2.Se toman los cuatro dígitos de la sucursal y enumerando de izquierda a derecha:
            //La primera cifra de la entidad se multiplica por 9.
            //La segunda cifra de la entidad se multiplica por 7.
            //La tercera cifra de la entidad se multiplica por 3.
            //La cuarta cifra de la entidad se multiplica por 6.
            acumulator += codSucursalArray[0] * 9;
            acumulator += codSucursalArray[1] * 7;
            acumulator += codSucursalArray[2] * 3;
            acumulator += codSucursalArray[3] * 6;
            //3.Se suman todos los resultados obtenidos.
            //4.Se divide entre 11 y nos quedamos con el resto de la división.
            resto = acumulator % 11;
            //5.A 11 le quitamos el resto anterior, y ese el primer dígito de control, con la salvedad de que
            //si nos da 10, el dígito es 1
            resto = 11 - resto;
            if (resto == 10)
            {
                digito1 = 1;
            }else
            {
                digito1 = resto;
            };

            //Calculo de segundo digito
            acumulator = 0;
            //1.Se toman los diez dígitos del número de cuenta y enumerando de izquierda a derecha:
            // La primera cifra de la cuenta se multiplica por 1.
            // La segunda cifra de la cuenta se multiplica por 2.
            // La tercera cifra de la cuenta se multiplica por 4.
            // La cuarta cifra de la cuenta se multiplica por 8.
            // La quinta cifra de la cuenta se multiplica por 5.
            // La sexta cifra de la cuenta se multiplica por 10.
            // La séptima cifra de la cuenta se multiplica por 9.
            // La octava cifra de la cuenta se multiplica por 7.
            // La novena cifra de la cuenta se multiplica por 3.
            // La décima cifra de la cuenta se multiplica por 6.
            acumulator += codCuentaArray[0];
            acumulator += codCuentaArray[1] * 2;
            acumulator += codCuentaArray[2] * 4;
            acumulator += codCuentaArray[3] * 8;
            acumulator += codCuentaArray[4] * 5;
            acumulator += codCuentaArray[5] * 10;
            acumulator += codCuentaArray[6] * 9;
            acumulator += codCuentaArray[7] * 7;
            acumulator += codCuentaArray[8] * 3;
            acumulator += codCuentaArray[9] * 6;

            //2.Se suman todos los resultados obtenidos.
            //3.Se divide entre 11 y nos quedamos con el resto de la división.
            resto = acumulator % 11;

            //4.A 11 le quitamos el resto anterior, y ese el segundo dígito de control, con la salvedad de
            //que si nos da 10, el dígito es 1.
            resto = 11 - resto;

            if (resto == 10)
            {
                digito2 = 1;
            }
            else
            {
                digito2 = resto;
            };


            return digito1 * 10 + digito2;
        }


        //Devuelve un array de enteros con cada cifra en una posición
        private int[] extraeCifras( long numero)
        {
            List<int> Cifras = new List<int>();
            while (numero > 0)
            {
                Cifras.Add((int) numero % 10);
                numero = numero / 10; 
            }
            int[] cifrasInt = Cifras.ToArray();
            return cifrasInt;
        }
    }
}
