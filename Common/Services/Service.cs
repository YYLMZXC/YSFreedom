using System;
using System.Threading.Tasks;

namespace YSFreedom.Common.Services
{
    public enum ServiceState { STOPPED, STOPPING, RUNNING }
    public class Service : IService, IDisposable
    {
        // Public properties
        public ServiceState State { get { return _State; } }

        // Internal state
        protected ServiceState _State = ServiceState.STOPPED;
        protected Task task;
        public virtual Task Start() { return null; }

        public virtual void Stop() { _State = ServiceState.STOPPING; }

        public virtual void Configure(object config) {}
        public virtual void Dispose() {}
    }
}