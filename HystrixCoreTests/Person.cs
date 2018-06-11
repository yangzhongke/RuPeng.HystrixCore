using RuPeng.HystrixCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HystrixCoreTests
{
    public class Person//需要public类
    {
        [HystrixCommand(nameof(Hello1FallBackAsync), MaxRetryTimes = 3, EnableCircuitBreaker = true)]
        public virtual async Task<string> HelloAsync(string name)//需要是虚方法
        {
            Console.WriteLine("尝试执行HelloAsync" + name);
            String s = null;
            s.ToString();
            return "ok" + name;
        }

        [HystrixCommand(nameof(Hello2FallBackAsync))]
        public virtual async Task<string> Hello1FallBackAsync(string name)
        {
            Console.WriteLine("Hello降级1" + name);
            String s = null;
            s.ToString();
            return "fail_1";
        }

        public virtual async Task<string> Hello2FallBackAsync(string name)
        {
            Console.WriteLine("Hello降级2" + name);

            return "fail_2";
        }

        [HystrixCommand(nameof(AddFall))]
        public virtual int Add(int i, int j)
        {
            String s = null;
            //s.ToString();
            return i + j;
        }
        public int AddFall(int i, int j)
        {
            return 0;
        }

        [HystrixCommand(nameof(TestFallBack), CacheTTLMilliseconds = 3000)]
        public virtual void Test(int i)
        {
            Console.WriteLine("Test" + i);
        }

        public virtual void TestFallBack(int i)
        {
            Console.WriteLine("Test" + i);
        }
    }
}
