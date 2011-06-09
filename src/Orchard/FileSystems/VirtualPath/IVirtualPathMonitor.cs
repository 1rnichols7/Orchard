﻿using Orchard.Caching;

namespace Orchard.FileSystems.VirtualPath {
    /// <summary>
    /// Enable monitoring changes over virtual path
    /// </summary>
    public interface IVirtualPathMonitor : ISingletonDependency {
        IVolatileToken WhenPathChanges(string virtualPath);
    }
}