using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class PartEventsLib : IPartEventsLib
    {
        private Inventor.Application inventorApp;

        public PartEventsSink_OnSurfaceBodyChangedEventHandler OnSurfaceBodyChangedDelegate
        { get; set; }

        public PartEvents PartEvents { get; private set; }

        private PartComponentDefinition partComponentDefinition;
        public PartComponentDefinition PartComponentDefinition 
        {
            get { return partComponentDefinition; } 
            set
            {
                partComponentDefinition = value;
                PartEvents = value.PartEvents;
            }
        }

        public PartEventsLib(Inventor.Application inventorApp, PartComponentDefinition
            partComponentDef)
        {
            this.inventorApp = inventorApp;
            this.PartEvents = partComponentDef.PartEvents;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.PartEvents.OnSurfaceBodyChanged -= this.OnSurfaceBodyChangedDelegate;
            this.OnSurfaceBodyChangedDelegate = null;
        }
    }
}
