using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideal.FrameWork.Interface
{
    internal interface IRuntimeModule
    {
        int Init();
        void Tick();
    }
}
