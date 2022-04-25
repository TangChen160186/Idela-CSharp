using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ideal.FrameWork.Interface;

namespace Ideal.FrameWork.Common
{
    internal class BaseApplication: IApplication
    {
        protected bool IsExit;

        public virtual bool IsQuit
        {
            get=>IsExit;
            set => IsExit=value;
        }
        public int Init()
        {
            IsExit = false;
            return 0;
        }
        //
        public virtual void Tick()
        {
            while (true)
            {
                Console.WriteLine("...");
                Thread.Sleep(1);
            }
        }
    }
}
