using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class FileAccessEventsLib : IFileAccessEventsLib
    {
        private Inventor.Application inventorApp;

        public FileAccessEventsSink_OnFileDirtyEventHandler OnFileDirtyDelegate
        { get; set; }
        public FileAccessEventsSink_OnFileResolutionEventHandler OnFileResolutionDelegate
        { get; set; }

        public FileAccessEvents FileAccessEvents { get; private set; }

        public FileAccessEventsLib(Inventor.Application inventorApp )
        {
            this.inventorApp = inventorApp;
            this.FileAccessEvents = inventorApp.FileAccessEvents;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.FileAccessEvents.OnFileDirty -= this.OnFileDirtyDelegate;
            this.OnFileDirtyDelegate = null;

            this.FileAccessEvents.OnFileResolution -= this.OnFileResolutionDelegate;
            this.OnFileResolutionDelegate = null;
        }
    }
}
