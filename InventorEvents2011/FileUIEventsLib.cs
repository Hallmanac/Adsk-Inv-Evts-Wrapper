using Inventor;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class FileUIEventsLib : IFileUIEventsLib
    {
        private Application inventorApp;

        public FileUIEventsLib(Application inventorApp)
        {
            this.inventorApp = inventorApp;
            FileUIEvents = inventorApp.FileUIEvents;
            Activate();
        }

        #region IFileUIEventsLib Members

        public FileUIEventsSink_OnFileInsertDialogEventHandler OnFileInsertDialogDelegate { get; set; }
        public FileUIEventsSink_OnFileInsertNewDialogEventHandler OnFileInsertNewDialogDelegate { get; set; }
        public FileUIEventsSink_OnFileNewEventHandler OnFileNewDelegate { get; set; }
        public FileUIEventsSink_OnFileNewDialogEventHandler OnFileNewDialogDelegate { get; set; }
        public FileUIEventsSink_OnFileOpenDialogEventHandler OnFileOpenDialogDelegate { get; set; }
        public FileUIEventsSink_OnFileOpenFromMRUEventHandler OnFileOpenFromMRUDelegate { get; set; }
        public FileUIEventsSink_OnFileSaveAsDialogEventHandler OnFileSaveAsDialogDelegate { get; set; }

        public FileUIEventsSink_OnPopulateFileMetadataEventHandler
            OnPopulateFileMetadataDelegate { get; set; }

        public FileUIEvents FileUIEvents { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            FileUIEvents.OnFileInsertDialog -= OnFileInsertDialogDelegate;
            OnFileInsertDialogDelegate = null;

            FileUIEvents.OnFileInsertNewDialog -= OnFileInsertNewDialogDelegate;
            OnFileInsertNewDialogDelegate = null;

            FileUIEvents.OnFileNew -= OnFileNewDelegate;
            OnFileNewDelegate = null;

            FileUIEvents.OnFileNewDialog -= OnFileNewDialogDelegate;
            OnFileNewDialogDelegate = null;

            FileUIEvents.OnFileOpenDialog -= OnFileOpenDialogDelegate;
            OnFileOpenDialogDelegate = null;

            FileUIEvents.OnFileOpenFromMRU -= OnFileOpenFromMRUDelegate;
            OnFileOpenFromMRUDelegate = null;

            FileUIEvents.OnFileSaveAsDialog -= OnFileSaveAsDialogDelegate;
            OnFileSaveAsDialogDelegate = null;

            FileUIEvents.OnPopulateFileMetadata -= OnPopulateFileMetadataDelegate;
            OnPopulateFileMetadataDelegate = null;
        }

        #endregion

        private void Activate()
        {
            FileUIEvents.OnFileInsertDialog += OnFileInsertDialogDelegate;

            FileUIEvents.OnFileInsertNewDialog += OnFileInsertNewDialogDelegate;

            FileUIEvents.OnFileNew += OnFileNewDelegate;

            FileUIEvents.OnFileNewDialog += OnFileNewDialogDelegate;

            FileUIEvents.OnFileOpenDialog += OnFileOpenDialogDelegate;

            FileUIEvents.OnFileOpenFromMRU += OnFileOpenFromMRUDelegate;

            FileUIEvents.OnFileSaveAsDialog += OnFileSaveAsDialogDelegate;

            FileUIEvents.OnPopulateFileMetadata += OnPopulateFileMetadataDelegate;
        }
    }
}