using System;
using Inventor;

namespace InventorEvents2011.Interfaces
{
    public interface IFileAccessEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.FileAccessEvents object
        /// </summary>
        FileAccessEvents FileAccessEvents { get; }

        #region Event Handler Delegates
        FileAccessEventsSink_OnFileDirtyEventHandler OnFileDirtyDelegate { get; set; }
        FileAccessEventsSink_OnFileResolutionEventHandler OnFileResolutionDelegate { get; set; }
        #endregion

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
