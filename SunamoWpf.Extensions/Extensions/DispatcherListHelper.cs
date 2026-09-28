namespace SunamoWpf.Extensions;

/// <summary>
/// Helper for safely copying items from a collection that is owned by a different thread
/// (e.g. a UI-bound <see cref="IList"/>) via the WPF <see cref="Dispatcher"/>.
/// </summary>
public static class DispatcherListHelper
{
    /// <summary>
    /// Copies all items of <paramref name="sourceList"/> into a new list, marshalling the read
    /// onto the thread owning <paramref name="dispatcher"/> so the source collection can be
    /// accessed safely from a background thread.
    /// </summary>
    /// <param name="sourceList">The list owned by the dispatcher's thread.</param>
    /// <param name="dispatcher">The dispatcher owning the thread that <paramref name="sourceList"/> belongs to.</param>
    /// <returns>A new list containing a snapshot of <paramref name="sourceList"/>'s items.</returns>
    public static List<object> ToList(IList sourceList, Dispatcher dispatcher)
    {
        var resultList = new List<object>(sourceList.Count);

        dispatcher.Invoke(() =>
        {
            foreach (var item in sourceList) resultList.Add(item);
        }, DispatcherPriority.ContextIdle);

        return resultList;
    }
}
