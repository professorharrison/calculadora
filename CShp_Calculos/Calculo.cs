namespace CShp_Calculos
{
    public static class Calculo
    {
        public static double Somar(double numero1, double numero2)
        {
            try
            {
                return (numero1 + numero2);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }                        
        }

        public static double Subtrair(double numero1, double numero2)
        {
            try
            {
                return (numero1 - numero2);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }            
        }

        public static double Multiplicar(double numero1, double numero2)
        {
            try
            {
                return (numero1 * numero2);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }            
        }

        public static double Dividir(double numero1, double numero2)
        {
            try
            {
                return (numero1 / numero2);
            }
            catch(System.DivideByZeroException)
            {
                return -999;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }            
        }

        public static bool IsNumeroPar(int numero)
        {
            return numero % 2 == 0;
        }
    }
}
