namespace SunamoWpf.Extensions.FileSystemWatcherExtended.nsn;

/// <summary>
/// This public class allows us to pass any type of watcher arguments to the calling object's 
/// handler via a single object instead of having to add a lot of event handlers for 
/// the various event args types.
/// </summary>

public class WatcherExEventArgs
{
    #region Properties
    FileSystemWatcherEx watcher = null;
    /// <summary>
    /// The watcher.
    /// </summary>
    public FileSystemWatcherEx Watcher
    {
        get
        {
            return watcher;
        }
        set
        {
            watcher = value;
        }
    }object arguments = null;
    /// <summary>
    /// The arguments.
    /// </summary>
    public object Arguments
    {
        get
        {
            return arguments;
        }
        set
        {
            arguments = value;
        }
    }ArgumentType argType = ArgumentType.StandardEvent;
    /// <summary>
    /// The arg type.
    /// </summary>
    public ArgumentType ArgType
    {
        get
        {
            return argType;
        }
        set
        {
            argType = value;
        }
    }NotifyFilters filter = NotifyFilters.FileName;
    /// <summary>
    /// The filter.
    /// </summary>
    public NotifyFilters Filter
    {
        get
        {
            return filter;
        }
        set
        {
            filter = value;
        }
    }
    #endregion Properties

    #region Constructors
    /// <summary>
    /// Initializes a new instance of the watcher ex event args class.
    /// </summary>
    /// <param name="watcher">The watcher.</param>
    /// <param name="arguments">The arguments.</param>
    /// <param name="argType">The arg type.</param>
    /// <param name="filter">The filter.</param>
    public WatcherExEventArgs(FileSystemWatcherEx watcher,
                              object arguments,
                              ArgumentType argType,
                              NotifyFilters filter)
    {
        Watcher = watcher;
        Arguments = arguments;
        ArgType = argType;
        Filter = filter;
    }
    /// <summary>
    /// Initializes a new instance of the watcher ex event args class.
    /// </summary>
    /// <param name="watcher">The watcher.</param>
    /// <param name="arguments">The arguments.</param>
    /// <param name="argType">The arg type.</param>
    public WatcherExEventArgs(FileSystemWatcherEx watcher,
                              object arguments,
                              ArgumentType argType)
    {
        Watcher = watcher;
        Arguments = arguments;
        ArgType = argType;
        Filter = NotifyFilters.Attributes;
    }
    #endregion Constructors
}