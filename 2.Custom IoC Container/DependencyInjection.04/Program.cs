using System;
using System.Net;

namespace DependencyInjection._04
{

    class Program
    {
        static void Main(string[] args)
        {

            Resolver resolver = new Resolver();
            resolver.Register<IPayment, Mellat>();
            resolver.Register<Buy, Buy>();

           var buy = resolver.Resolve<Buy>();
 
            buy.Pay();
            Console.ReadLine();
 
        
        }
 
    }
 
}
