using InventorEvents2010.Interfaces;

namespace InventorEvents2010.ExperimentalStuff
{
    public interface IInventorEvent<TEventGroup, TEventLibrary>
     where TEventLibrary : IEventLibraryType<TEventGroup>
    {
        TEventGroup EventGroup { get; }
        TEventLibrary EventLibrary { get; }
    }
}
