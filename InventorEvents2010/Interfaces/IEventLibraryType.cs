using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventorEvents2010.Interfaces
{
    public interface IEventLibraryType<T>
    {
        T GetEventGroup();
        void Deactivate();
    }
}
