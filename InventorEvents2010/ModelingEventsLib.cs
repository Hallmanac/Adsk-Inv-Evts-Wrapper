using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class ModelingEventsLib : IModelingEventsLib
    {
        private Inventor.Application inventorApp;

        public ModelingEventsSink_OnClientFeatureDoubleClickEventHandler
            OnClientFeatureDoubleClickDelegate { get; set; }
        public ModelingEventsSink_OnClientFeatureSolveEventHandler OnClientFeatureSolveDelegate
        { get; set; }
        public ModelingEventsSink_OnDeleteEventHandler OnDeleteDelegate
        { get; set; }
        public ModelingEventsSink_OnFeatureChangeEventHandler OnFeatureChangeDelegate
        { get; set; }
        public ModelingEventsSink_OnGenerateMemberEventHandler OnGenerateMemberDelegate
        { get; set; }
        public ModelingEventsSink_OnNewFeatureEventHandler OnNewFeatureDelegate
        { get; set; }
        public ModelingEventsSink_OnNewParameterEventHandler OnNewParameterDelegate
        { get; set; }
        public ModelingEventsSink_OnParameterChangeEventHandler OnParameterChangeDelegate
        { get; set; }

        public ModelingEvents ModelingEvents { get; private set; }

        public ModelingEventsLib(Inventor.Application inventorApp)
        {
            this.inventorApp = inventorApp;
            this.ModelingEvents = inventorApp.ModelingEvents;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.ModelingEvents.OnClientFeatureDoubleClick -= 
                this.OnClientFeatureDoubleClickDelegate;
            this.OnClientFeatureDoubleClickDelegate = null;

            this.ModelingEvents.OnClientFeatureSolve -= this.OnClientFeatureSolveDelegate;
            this.OnClientFeatureSolveDelegate = null;

            this.ModelingEvents.OnDelete -= this.OnDeleteDelegate;
            this.OnDeleteDelegate = null;

            this.ModelingEvents.OnFeatureChange -= this.OnFeatureChangeDelegate;
            this.OnFeatureChangeDelegate = null;

            this.ModelingEvents.OnGenerateMember -= this.OnGenerateMemberDelegate;
            this.OnGenerateMemberDelegate = null;

            this.ModelingEvents.OnNewFeature -= this.OnNewFeatureDelegate;
            this.OnNewFeatureDelegate = null;

            this.ModelingEvents.OnNewParameter -= this.OnNewParameterDelegate;
            this.OnNewParameterDelegate = null;

            this.ModelingEvents.OnParameterChange -= this.OnParameterChangeDelegate;
            this.OnParameterChangeDelegate = null;
        }
    }
}
