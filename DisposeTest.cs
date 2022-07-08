using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphicsPathsDemo
{
    public class DisposeTest : IDisposable
    {
        /// <summary>
        /// 离开终结队列Finalization Queue
        /// 设置对象的阻止终结器代码
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
