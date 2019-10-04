using AspectCore.DynamicProxy;
using System;
using System.Threading;

namespace HystrixCoreTests
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyGeneratorBuilder proxyGeneratorBuilder = new ProxyGeneratorBuilder();
            using (IProxyGenerator proxyGenerator = proxyGeneratorBuilder.Build())
            {
                //IPerson p = proxyGenerator.CreateClassProxy<Person>();
                Person p = proxyGenerator.CreateClassProxy<Person>();
                //   Console.WriteLine(p.HelloAsync("yzk").Result);
                // Console.WriteLine(p.Add(1, 2));
                while (true)
                {
                    Console.WriteLine(p.HelloAsync("yzk").Result);
                    Thread.Sleep(500);
                }
            }
        }
    }
}
