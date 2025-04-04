namespace ex5_6
{
    internal class Program
    {
        class Product
        {
            public string name = "default";
            public int price = 1000;
            public static double PI = 3.14;
        }

        static void Main(string[] args)
        {
            Product prod = new Product() { name = "감자", price = 5000 };

            Console.WriteLine($"{prod.name} : {prod.price}원");
            Console.WriteLine(Math.PI);
            Console.WriteLine(Product.PI);
        }
    }
}
