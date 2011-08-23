using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    /// <summary>
    /// Example implementation:
    ///   uiEvents = new InventorEvent &lt;UserInterfaceEvents, UserInterfaceEventsLib&gt;
    ///         (new UserInterfaceEventsLib(invApp));
    ///   uiEvents.EventLibrary.OnEnvironmentChangeDelegate += (EventGroup_OnEnvironmentChange);
    ///   uiEvents.EventGroup.OnEnvironmentChange += uiEvents.EventLibrary.OnEnvironmentChangeDelegate;
    /// </summary>
    /// <typeparam name="TInventorEventGroup"></typeparam>
    /// <typeparam name="TEventLibrary"></typeparam>
    public class InventorEvent<TInventorEventGroup, TEventLibrary> : 
        IInventorEvent<TInventorEventGroup,TEventLibrary> where TEventLibrary : 
        IEventLibraryType<TInventorEventGroup>
    {
        public TEventLibrary EventLibrary { get; private set; }

        public TInventorEventGroup EventGroup { get { return EventLibrary.GetEventGroup(); } }
        
        //Constructor
        public InventorEvent(TEventLibrary eventLibrary)
        {
            EventLibrary = eventLibrary;
        }

        /*Example implementations:
         * uiEvents = new InventorEvent<UserInterfaceEvents, UserInterfaceEventsLib>
                (new UserInterfaceEventsLib(invApp));
            uiEvents.EventLibrary.OnEnvironmentChangeDelegate += (EventGroup_OnEnvironmentChange);
            uiEvents.EventGroup.OnEnvironmentChange += uiEvents.EventLibrary.OnEnvironmentChangeDelegate;*/
    }
}
