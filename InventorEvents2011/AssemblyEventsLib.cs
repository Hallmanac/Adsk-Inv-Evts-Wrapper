using Inventor;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class AssemblyEventsLib : IAssemblyEventsLib
    {
        private readonly Application inventorApp;

        public AssemblyEventsLib(Application inventorApp)
        {
            this.inventorApp = inventorApp;
            AssemblyEvents = this.inventorApp.AssemblyEvents;
            Activate();
        }

        #region IAssemblyEventsLib Members

        public AssemblyEventsSink_OnAssemblyChangeEventHandler OnAssemblyChangeDelegate { get; set; }
        public AssemblyEventsSink_OnAssemblyChangedEventHandler OnAssemblyChangedDelegate { get; set; }
        public AssemblyEventsSink_OnAssemblySolveEventHandler OnAssemblySolveDelegate { get; set; }
        public AssemblyEventsSink_OnDeleteEventHandler OnDeleteDelegate { get; set; }
        public AssemblyEventsSink_OnNewConstraintEventHandler OnNewConstraint { get; set; }
        public AssemblyEventsSink_OnNewOccurrenceEventHandler OnNewOccurrenceDelegate { get; set; }
        public AssemblyEventsSink_OnOccurrenceChangeEventHandler OnOccurrenceChangeDelegate { get; set; }

        public AssemblyEvents AssemblyEvents { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            AssemblyEvents.OnAssemblyChange -= OnAssemblyChangeDelegate;
            OnAssemblyChangeDelegate = null;

            AssemblyEvents.OnAssemblyChanged -= OnAssemblyChangedDelegate;
            OnAssemblyChangedDelegate = null;

            AssemblyEvents.OnAssemblySolve -= OnAssemblySolveDelegate;
            OnAssemblySolveDelegate = null;

            AssemblyEvents.OnDelete -= OnDeleteDelegate;
            OnDeleteDelegate = null;

            AssemblyEvents.OnNewConstraint -= OnNewConstraint;
            OnNewConstraint = null;

            AssemblyEvents.OnNewOccurrence -= OnNewOccurrenceDelegate;
            OnNewOccurrenceDelegate = null;

            AssemblyEvents.OnOccurrenceChange -= OnOccurrenceChangeDelegate;
            OnOccurrenceChangeDelegate = null;
        }

        #endregion

        private void Activate()
        {
            AssemblyEvents.OnAssemblyChange += OnAssemblyChangeDelegate;

            AssemblyEvents.OnAssemblyChanged += OnAssemblyChangedDelegate;

            AssemblyEvents.OnAssemblySolve += OnAssemblySolveDelegate;

            AssemblyEvents.OnDelete += OnDeleteDelegate;

            AssemblyEvents.OnNewConstraint += OnNewConstraint;

            AssemblyEvents.OnNewOccurrence += OnNewOccurrenceDelegate;

            AssemblyEvents.OnOccurrenceChange += OnOccurrenceChangeDelegate;
        }
    }
}