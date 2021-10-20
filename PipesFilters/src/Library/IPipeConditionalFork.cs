using System;
using System.Collections.Generic;
using System.Text;

namespace CompAndDel
{
    public interface IPipeConditionalFork
    {
        IPicture Send(IPicture picture);
    }
}