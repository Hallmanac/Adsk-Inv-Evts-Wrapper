using System;
using Inventor;

namespace InventorEvents2010.Interfaces
{
    public interface IDocumentEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.DocumentEvents object
        /// </summary>
        DocumentEvents DocumentEvents { get; }

        #region Event Handler Delegates
        DocumentEventsSink_OnActivateEventHandler OnActivateDelegate { get; set; }
        DocumentEventsSink_OnChangeEventHandler OnChangDelegate { get; set; }
        DocumentEventsSink_OnChangeSelectSetEventHandler OnChangeSelectSetDelegate { get; set; }
        DocumentEventsSink_OnCloseEventHandler OnCloseDelegate { get; set; }
        DocumentEventsSink_OnDeactivateEventHandler OnDeactivateDelegate { get; set; }
        DocumentEventsSink_OnDeleteEventHandler OnDeleteDelegate { get; set; }
        DocumentEventsSink_OnSaveEventHandler OnSaveDelegate { get; set; }
        #endregion

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
