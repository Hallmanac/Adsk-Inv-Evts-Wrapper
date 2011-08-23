using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class StyleEventsLib : IStyleEventsLib
    {
        private Inventor.Application inventorApp;

        public StyleEventsSink_OnActivateStyleEventHandler OnActivateStyleDelegate
        { get; set; }
        public StyleEventsSink_OnDeleteEventHandler OnDeleteDelegate
        { get; set; }
        public StyleEventsSink_OnMigrateStyleLibraryEventHandler OnMigrateStyleLibraryDelegate
        { get; set; }
        public StyleEventsSink_OnNewStyleEventHandler OnNewStyleDelegate
        { get; set; }
        public StyleEventsSink_OnStyleChangeEventHandler OnStyleChangeDelegate
        { get; set; }

        public StyleEvents StyleEvents { get; private set; }

        public StyleEventsLib(Inventor.Application inventorApp)
        {
            this.inventorApp = inventorApp;
            this.StyleEvents = inventorApp.StyleEvents;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.StyleEvents.OnActivateStyle -= this.OnActivateStyleDelegate;
            this.OnActivateStyleDelegate = null;

            this.StyleEvents.OnDelete -= this.OnDeleteDelegate;
            this.OnDeleteDelegate = null;

            this.StyleEvents.OnMigrateStyleLibrary -= this.OnMigrateStyleLibraryDelegate;
            this.OnMigrateStyleLibraryDelegate = null;

            this.StyleEvents.OnNewStyle -= this.OnNewStyleDelegate;
            this.OnNewStyleDelegate = null;

            this.StyleEvents.OnStyleChange -= this.OnStyleChangeDelegate;
            this.OnStyleChangeDelegate = null;
        }
    }
}
