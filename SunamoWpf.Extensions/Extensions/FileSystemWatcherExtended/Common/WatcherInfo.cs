namespace SunamoWpf.Extensions.FileSystemWatcherExtended.Common;

    /// <summary>
    /// Represents the watcher info type.
    /// </summary>
    public class WatcherInfo
    {
        string watchPath = null;
        /// <summary>
        /// The watch path.
        /// </summary>
        public string WatchPath
        {
            get
            {
                return watchPath;
            }
            set
            {
                watchPath = value;
            }
        }

    bool includeSubFolders = false;
        /// <summary>
        /// The include sub folders.
        /// </summary>
        public bool IncludeSubFolders
        {
            get
            {
                return includeSubFolders;
            }
            set
            {
                includeSubFolders = value;
            }
        }

    bool watchForError = false;
        /// <summary>
        /// The watch for error.
        /// </summary>
        public bool WatchForError
        {
            get
            {
                return watchForError;
            }
            set
            {
                watchForError = value;
            }
        }bool watchForDisposed = false;
        /// <summary>
        /// The watch for disposed.
        /// </summary>
        public bool WatchForDisposed
        {
            get
            {
                return watchForDisposed;
            }
            set
            {
                watchForDisposed = value;
            }
        }System.IO.NotifyFilters changesFilters = NotifyFilters.FileName;
        /// <summary>
        /// The changes filters.
        /// </summary>
        public System.IO.NotifyFilters ChangesFilters
        {
            get
            {
                return changesFilters;
            }
            set
            {
                changesFilters = value;
            }
        }WatcherChangeTypes watchesFilters = WatcherChangeTypes.All;
        /// <summary>
        /// The watches filters.
        /// </summary>
        public WatcherChangeTypes WatchesFilters
        {
            get
            {
                return watchesFilters;
            }
            set
            {
                watchesFilters = value;
            }
        }string fileFilter = null;
        /// <summary>
        /// The file filter.
        /// </summary>
        public string FileFilter
        {
            get
            {
                return fileFilter;
            }
            set
            {
                fileFilter = value;
            }
        }uint bufferKBytes = 0;
        /// <summary>
        /// The buffer k bytes.
        /// </summary>
        public uint BufferKBytes
        {
            get
            {
                return bufferKBytes;
            }
            set
            {
                bufferKBytes = value;
            }
        }int monitorPathInterval = 0;
        /// <summary>
        /// The monitor path interval.
        /// </summary>
        public int MonitorPathInterval
        {
            get
            {
                return monitorPathInterval;
            }
            set
            {
                monitorPathInterval = value;
            }
        }

        // -------------------------------------------------------------------------------
        /// <summary>
        /// Initializes a new instance of the watcher info class.
        /// </summary>
        public WatcherInfo()
        {
            this.WatchPath = "";
            this.IncludeSubFolders = false;
            this.WatchForError = false;
            this.WatchForDisposed = false;
            this.ChangesFilters = NotifyFilters.Attributes;
            this.WatchesFilters = WatcherChangeTypes.All;
            this.FileFilter = "";
            this.BufferKBytes = 8;
            this.MonitorPathInterval = 0;
        }
    }