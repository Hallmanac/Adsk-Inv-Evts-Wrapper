using System;
using Inventor;

namespace InventorEvents2011.Interfaces
{
    public interface IApplicationEventsLib
    {
        /// <summary>
        /// Read Only property that retrieves the Inventor.ApplicationEvents object
        /// </summary>
        ApplicationEvents ApplicationEvents { get; }

        #region Event Handler Delegates
        ApplicationEventsSink_OnActivateDocumentEventHandler OnActivateDocumentDelegate
        { get; set; }
        ApplicationEventsSink_OnActivateViewEventHandler OnActivateViewDelegate
        { get; set; }
        ApplicationEventsSink_OnActiveProjectChangedEventHandler
            OnActiveProjectChangedDelegate { get; set; }
        ApplicationEventsSink_OnApplicationOptionChangeEventHandler
            OnApplicationOptionChangeDelegate { get; set; }
        ApplicationEventsSink_OnCloseDocumentEventHandler OnCloseDocumentDelegate
        { get; set; }
        ApplicationEventsSink_OnCloseViewEventHandler OnCloseViewDelegate
        { get; set; }
        ApplicationEventsSink_OnDeactivateDocumentEventHandler OnDeactivateDocumentDelegate
        { get; set; }
        ApplicationEventsSink_OnDeactivateViewEventHandler OnDeactivateViewDelegate
        { get; set; }
        ApplicationEventsSink_OnDisplayModeChangeEventHandler OnDisplayModeChangeDelegate
        { get; set; }
        ApplicationEventsSink_OnDocumentChangeEventHandler OnDocumentChangeDelegate
        { get; set; }
        ApplicationEventsSink_OnInitializeDocumentEventHandler
            OnInitializeDocumentDelegate { get; set; }
        ApplicationEventsSink_OnMigrateDocumentEventHandler OnMigrateDocumentDelegate
        { get; set; }
        ApplicationEventsSink_OnNewDocumentEventHandler OnNewDocumentDelegate
        { get; set; }
        ApplicationEventsSink_OnNewEditObjectEventHandler OnNewEditObjectDelegate
        { get; set; }
        ApplicationEventsSink_OnNewViewEventHandler OnNewViewDelegate
        { get; set; }
        ApplicationEventsSink_OnOpenDocumentEventHandler OnOpenDocumentDelegate
        { get; set; }
        ApplicationEventsSink_OnQuitEventHandler OnQuitDelegate
        { get; set; }
        ApplicationEventsSink_OnReadyEventHandler OnReadyDelegate
        { get; set; }
        ApplicationEventsSink_OnSaveDocumentEventHandler OnSaveDocumentDelegate
        { get; set; }
        ApplicationEventsSink_OnTerminateDocumentEventHandler OnTerminateDocumentDelegate
        { get; set; }
        ApplicationEventsSink_OnTranslateDocumentEventHandler OnTranslateDocumentDelegate
        { get; set; }
        #endregion
        
        /// <summary>
        /// Removes all event handler delegates from their respectives events and nullifies them
        /// </summary>
        void Deactivate();
    }
}
