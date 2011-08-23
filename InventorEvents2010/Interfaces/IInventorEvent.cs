using System;

namespace InventorEvents2010.Interfaces
{
    public interface IInventorEvent<TEventGroup, TEventLibrary>
     where TEventLibrary : IEventLibraryType<TEventGroup>
    {
        TEventGroup EventGroup { get; }
        TEventLibrary EventLibrary { get; }
    }
}
