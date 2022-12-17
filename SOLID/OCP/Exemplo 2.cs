namespace SOLID.OCP
{
    //Temos somente musica inicialmente
    public class Aqi
    {
        public static double CalculateAqi(double measurement)
        {
            return measurement * 0.5 + 6;
        }
    }

    //E se a lei muda?

    //Erradissimo
    public class Aqi
    {
        public static double CalculateAqi(double measurement)
        {
            return measurement * 1.5 + 10;
        }
    }

    //O ideal seria receber uma interface como parametro pro de calcular

    public interface IAqiPolicyDeprecated
    {
        public void Calculate(double measurement)
        {
            return measurement * 0.5 + 6;
        }
    }

    public interface IAqiPolicy
    {
        public double Calculate(double measurement)
        {
            return measurement * 1.5 + 10;
        }
    }

    public class Aqi
    {
        public static double CalculateAqi(IAqiPolicy aqiPolicy, double measurement)
        {
            return aqiPolicy.Calculate(measurement);
        }
    }

    //E ai implementam a interface correta
}


