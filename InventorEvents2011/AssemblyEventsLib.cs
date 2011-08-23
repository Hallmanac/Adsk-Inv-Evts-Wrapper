using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class AssemblyEventsLib : IAssemblyEventsLib
    {
        private Inventor.Application inventorApp;

        public AssemblyEventsSink_OnAssemblyChangeEventHandler OnAssemblyChangeDelegate
        { get; set; }
        public AssemblyEventsSink_OnAssemblyChangedEventHandler OnAssemblyChangedDelegate
        { get; set; }
        public AssemblyEventsSink_OnAssemblySolveEventHandler OnAssemblySolveDelegate
        { get; set; }
        public AssemblyEventsSink_OnDeleteEventHandler OnDeleteDelegate
        { get; set; }
        public AssemblyEventsSink_OnNewConstraintEventHandler OnNewConstraint
        { get; set; }
        public AssemblyEventsSink_OnNewOccurrenceEventHandler OnNewOccurrenceDelegate
        { get; set; }
        public AssemblyEventsSink_OnOccurrenceChangeEventHandler OnOccurrenceChangeDelegate
        { get; set; }

        public AssemblyEvents AssemblyEvents { get; private set; }

        public AssemblyEventsLib(Inventor.Application inventorApp)
        {
            this.inventorApp = inventorApp;
            this.AssemblyEvents = this.inventorApp.AssemblyEvents;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.AssemblyEvents.OnAssemblyChange -= this.OnAssemblyChangeDelegate;
            this.OnAssemblyChangeDelegate = null;

            this.AssemblyEvents.OnAssemblyChanged -= this.OnAssemblyChangedDelegate;
            this.OnAssemblyChangedDelegate = null;

            this.AssemblyEvents.OnAssemblySolve -= this.OnAssemblySolveDelegate;
            this.OnAssemblySolveDelegate = null;

            this.AssemblyEvents.OnDelete -= this.OnDeleteDelegate;
            this.OnDeleteDelegate = null;

            this.AssemblyEvents.OnNewConstraint -= this.OnNewConstraint;
            this.OnNewConstraint = null;

            this.AssemblyEvents.OnNewOccurrence -= this.OnNewOccurrenceDelegate;
            this.OnNewOccurrenceDelegate = null;

            this.AssemblyEvents.OnOccurrenceChange -= this.OnOccurrenceChangeDelegate;
            this.OnOccurrenceChangeDelegate = null;
        }
    }
}
