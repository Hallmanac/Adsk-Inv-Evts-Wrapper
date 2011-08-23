using System;
using Inventor;

namespace InventorEvents2011.Interfaces
{
    public interface IFileManagerEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.FileManagerEvents object
        /// </summary>
        FileManagerEvents FileManagerEvents { get; }

        #region Event Handler Delegates
        FileManagerEventsSink_OnFileCopyEventHandler OnFileCopyDelegate { get; set; }
        FileManagerEventsSink_OnFileDeleteEventHandler OnFileDeleteDelegate { get; set; }
        #endregion

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
