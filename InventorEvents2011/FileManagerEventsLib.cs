using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class FileManagerEventsLib : IFileManagerEventsLib
    {
        private Inventor.Application inventorApp;

        public FileManagerEventsSink_OnFileCopyEventHandler OnFileCopyDelegate
        { get; set; }
        public FileManagerEventsSink_OnFileDeleteEventHandler OnFileDeleteDelegate
        { get; set; }

        public FileManagerEvents FileManagerEvents { get; private set; }

        public FileManagerEventsLib(Inventor.Application inventorApp)
        {
            this.inventorApp = inventorApp;
            this.FileManagerEvents = inventorApp.FileManager.FileManagerEvents;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.FileManagerEvents.OnFileCopy -= this.OnFileCopyDelegate;
            this.OnFileCopyDelegate = null;

            this.FileManagerEvents.OnFileDelete -= this.OnFileDeleteDelegate;
            this.OnFileDeleteDelegate = null;
        }
    }
}
