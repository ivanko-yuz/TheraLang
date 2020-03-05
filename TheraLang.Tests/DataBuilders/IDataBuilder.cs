using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.Tests.Builders
{
    interface IDataBuilder<T>
    {
        T Build();
    }
}
