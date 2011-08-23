using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class FileUIEventsLib : IFileUIEventsLib
    {
        private Inventor.Application inventorApp;

        public FileUIEventsSink_OnFileInsertDialogEventHandler OnFileInsertDialogDelegate
        { get; set; }
        public FileUIEventsSink_OnFileInsertNewDialogEventHandler OnFileInsertNewDialogDelegate
        { get; set; }
        public FileUIEventsSink_OnFileNewEventHandler OnFileNewDelegate
        { get; set; }
        public FileUIEventsSink_OnFileNewDialogEventHandler OnFileNewDialogDelegate
        { get; set; }
        public FileUIEventsSink_OnFileOpenDialogEventHandler OnFileOpenDialogDelegate
        { get; set; }
        public FileUIEventsSink_OnFileOpenFromMRUEventHandler OnFileOpenFromMRUDelegate
        { get; set; }
        public FileUIEventsSink_OnFileSaveAsDialogEventHandler OnFileSaveAsDialogDelegate
        { get; set; }
        public FileUIEventsSink_OnPopulateFileMetadataEventHandler
            OnPopulateFileMetadataDelegate { get; set; }

        public FileUIEvents FileUIEvents { get; private set; }

        public FileUIEventsLib(Inventor.Application inventorApp)
        {
            this.inventorApp = inventorApp;
            this.FileUIEvents = inventorApp.FileUIEvents;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.FileUIEvents.OnFileInsertDialog -= this.OnFileInsertDialogDelegate;
            this.OnFileInsertDialogDelegate = null;

            this.FileUIEvents.OnFileInsertNewDialog -= this.OnFileInsertNewDialogDelegate;
            this.OnFileInsertNewDialogDelegate = null;

            this.FileUIEvents.OnFileNew -= this.OnFileNewDelegate;
            this.OnFileNewDelegate = null;

            this.FileUIEvents.OnFileNewDialog -= this.OnFileNewDialogDelegate;
            this.OnFileNewDialogDelegate = null;

            this.FileUIEvents.OnFileOpenDialog -= this.OnFileOpenDialogDelegate;
            this.OnFileOpenDialogDelegate = null;

            this.FileUIEvents.OnFileOpenFromMRU -= this.OnFileOpenFromMRUDelegate;
            this.OnFileOpenFromMRUDelegate = null;

            this.FileUIEvents.OnFileSaveAsDialog -= this.OnFileSaveAsDialogDelegate;
            this.OnFileSaveAsDialogDelegate = null;

            this.FileUIEvents.OnPopulateFileMetadata -= this.OnPopulateFileMetadataDelegate;
            this.OnPopulateFileMetadataDelegate = null;
        }
    }
}
