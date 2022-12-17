
//Wrong
//public class Buy
//{
//    public static void Buy(int productId);
//    public static decimal GetCartPrice(int cartId);
//    public static decimal GetShipPrice(string cep);
//    public static bool isValidCupom(string cupom);
//}

public class Buy
{
    public static void Buy(int productId);
}

public class Cart
{
    public static decimal GetCartPrice(int cartId);
}

public class Ship
{
    public static decimal GetShipPrice(string cep);
}

public class Cupom
{
    public static bool isValidCupom(string cupom);
}