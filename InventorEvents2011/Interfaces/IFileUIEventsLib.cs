using System;
using Inventor;

namespace InventorEvents2011.Interfaces
{
    public interface IFileUIEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.FileUIEvents object
        /// </summary>
        FileUIEvents FileUIEvents { get; }

        #region Event Handler delegates
        FileUIEventsSink_OnFileInsertDialogEventHandler OnFileInsertDialogDelegate { get; set; }
        FileUIEventsSink_OnFileInsertNewDialogEventHandler OnFileInsertNewDialogDelegate { get; set; }
        FileUIEventsSink_OnFileNewEventHandler OnFileNewDelegate { get; set; }
        FileUIEventsSink_OnFileNewDialogEventHandler OnFileNewDialogDelegate { get; set; }
        FileUIEventsSink_OnFileOpenDialogEventHandler OnFileOpenDialogDelegate { get; set; }
        FileUIEventsSink_OnFileOpenFromMRUEventHandler OnFileOpenFromMRUDelegate { get; set; }
        FileUIEventsSink_OnFileSaveAsDialogEventHandler OnFileSaveAsDialogDelegate { get; set; }
        FileUIEventsSink_OnPopulateFileMetadataEventHandler OnPopulateFileMetadataDelegate { get; set; }
        #endregion

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
