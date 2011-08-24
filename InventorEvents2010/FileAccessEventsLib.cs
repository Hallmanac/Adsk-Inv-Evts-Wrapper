using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class FileAccessEventsLib : IFileAccessEventsLib
    {
        private Application inventorApp;

        public FileAccessEventsLib(Application inventorApp)
        {
            this.inventorApp = inventorApp;
            FileAccessEvents = inventorApp.FileAccessEvents;
            Activate();
        }

        #region IFileAccessEventsLib Members

        public FileAccessEventsSink_OnFileDirtyEventHandler OnFileDirtyDelegate { get; set; }
        public FileAccessEventsSink_OnFileResolutionEventHandler OnFileResolutionDelegate { get; set; }

        public FileAccessEvents FileAccessEvents { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            FileAccessEvents.OnFileDirty -= OnFileDirtyDelegate;
            OnFileDirtyDelegate = null;

            FileAccessEvents.OnFileResolution -= OnFileResolutionDelegate;
            OnFileResolutionDelegate = null;
        }

        #endregion

        private void Activate()
        {
            FileAccessEvents.OnFileDirty += OnFileDirtyDelegate;
            FileAccessEvents.OnFileResolution += OnFileResolutionDelegate;
        }
    }
}