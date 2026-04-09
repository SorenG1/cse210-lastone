using System;

class Program
{
    static void Main(string[] args)
    {
        //first order 
        Address a1 = new Address("236 S 1st W", "Rexburg", "ID", "USA");
        Customer c1 = new Customer("Jorge Cedillo", a1);
        Order o1 = new Order(c1);

        o1.AddProduct(new Product("Marvel Comic Book: Civil War", "MVL 6767", 4.99, 45));
        o1.AddProduct(new Product("Jabulani Soccer Ball", "WCB 2010", 123.99, 6));

        Console.WriteLine("Order 1 Packing Laber:");
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label: ");
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"Total: ${o1.GetTotalCost()}\n");

        //second order
        Address a2 = new Address("Cerro de la Luna #1", "Tlalnepantla de Baz", "Estado de Mexico", "Mexico");
        Customer c2 = new Customer("Anna Ross", a2);
        Order o2 = new Order (c2);

        o2.AddProduct(new Product("Taco Seasoning: Botanera", "SPC 50", 1.39, 40));
        o2.AddProduct(new Product("Canon Rebel T7 DSLR Camera", "CNN 9315", 599.99, 3));

        Console.WriteLine("Order 2 Packing Label;");
        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine("Order 2 Shippping Label: ");
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"Total: ${o2.GetTotalCost()}\n");
    }
}