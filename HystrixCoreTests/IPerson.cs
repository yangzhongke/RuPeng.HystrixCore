using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HystrixCoreTests
{
    public interface IPerson
    {
        Task<string> HelloAsync(string name);
        int Add(int i, int j);
        void Test(int i);
    }
}
