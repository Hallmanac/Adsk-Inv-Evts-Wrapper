using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class FileManagerEventsLib : IFileManagerEventsLib
    {
        private Application inventorApp;

        public FileManagerEventsLib(Application inventorApp)
        {
            this.inventorApp = inventorApp;
            FileManagerEvents = inventorApp.FileManager.FileManagerEvents;
            Activate();
        }

        #region IFileManagerEventsLib Members

        public FileManagerEventsSink_OnFileCopyEventHandler OnFileCopyDelegate { get; set; }
        public FileManagerEventsSink_OnFileDeleteEventHandler OnFileDeleteDelegate { get; set; }

        public FileManagerEvents FileManagerEvents { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            FileManagerEvents.OnFileCopy -= OnFileCopyDelegate;
            OnFileCopyDelegate = null;

            FileManagerEvents.OnFileDelete -= OnFileDeleteDelegate;
            OnFileDeleteDelegate = null;
        }

        #endregion

        private void Activate()
        {
            FileManagerEvents.OnFileCopy += OnFileCopyDelegate;
            FileManagerEvents.OnFileDelete += OnFileDeleteDelegate;
        }
    }
}