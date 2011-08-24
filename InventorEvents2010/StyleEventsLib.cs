using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class StyleEventsLib : IStyleEventsLib
    {
        private Application inventorApp;

        public StyleEventsLib(Application inventorApp)
        {
            this.inventorApp = inventorApp;
            StyleEvents = inventorApp.StyleEvents;
            Activate();
        }

        #region IStyleEventsLib Members

        public StyleEventsSink_OnActivateStyleEventHandler OnActivateStyleDelegate { get; set; }
        public StyleEventsSink_OnDeleteEventHandler OnDeleteDelegate { get; set; }
        public StyleEventsSink_OnMigrateStyleLibraryEventHandler OnMigrateStyleLibraryDelegate { get; set; }
        public StyleEventsSink_OnNewStyleEventHandler OnNewStyleDelegate { get; set; }
        public StyleEventsSink_OnStyleChangeEventHandler OnStyleChangeDelegate { get; set; }

        public StyleEvents StyleEvents { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            StyleEvents.OnActivateStyle -= OnActivateStyleDelegate;
            OnActivateStyleDelegate = null;

            StyleEvents.OnDelete -= OnDeleteDelegate;
            OnDeleteDelegate = null;

            StyleEvents.OnMigrateStyleLibrary -= OnMigrateStyleLibraryDelegate;
            OnMigrateStyleLibraryDelegate = null;

            StyleEvents.OnNewStyle -= OnNewStyleDelegate;
            OnNewStyleDelegate = null;

            StyleEvents.OnStyleChange -= OnStyleChangeDelegate;
            OnStyleChangeDelegate = null;
        }

        #endregion

        private void Activate()
        {
            StyleEvents.OnActivateStyle += OnActivateStyleDelegate;

            StyleEvents.OnDelete += OnDeleteDelegate;

            StyleEvents.OnMigrateStyleLibrary += OnMigrateStyleLibraryDelegate;

            StyleEvents.OnNewStyle += OnNewStyleDelegate;

            StyleEvents.OnStyleChange += OnStyleChangeDelegate;
        }
    }
}