# RuPeng.HystrixCore

Technology stack: C#, .Net Core, Polly

Description: It is a latency and fault tolerance library, with abilities of circuit breaker, fallback, and retry.

Example:
```
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
                Person p = proxyGenerator.CreateClassProxy<Person>();
                Console.WriteLine(p.HelloAsync("yzk").Result);
            }
			Console.ReadKey();
        }
    }
}

```
Check the project 'HystrixCoreTests' for the whole demo case.