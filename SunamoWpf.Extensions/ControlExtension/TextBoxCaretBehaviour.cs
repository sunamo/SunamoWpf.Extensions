namespace SunamoWpf.ControlExtension;

/// <summary>
/// In TextBox is needed AcceptsReturn="True" SunamoWpfControlExtension:TextBoxCaretBehaviour.ObserveCaret="True"
/// </summary>
public class TextBoxCaretBehaviour
{
    /// <summary>
    /// The observe caret property.
    /// </summary>
    public static readonly DependencyProperty ObserveCaretProperty =
    DependencyProperty.RegisterAttached
    (
        "ObserveCaret",
        typeof(bool),
        typeof(TextBoxCaretBehaviour),
        new UIPropertyMetadata(false, OnObserveCaretPropertyChanged)
    );

    /// <summary>
    /// Get observe caret.
    /// </summary>
    /// <param name="obj">The obj.</param>
    /// <returns>The get observe caret result.</returns>
    public static bool GetObserveCaret(DependencyObject obj)
    {
        return (bool)obj.GetValue(ObserveCaretProperty);
    }

    /// <summary>
    /// Set observe caret.
    /// </summary>
    /// <param name="obj">The obj.</param>
    /// <param name="value">The value.</param>
    public static void SetObserveCaret(DependencyObject obj, bool value)
    {
        obj.SetValue(ObserveCaretProperty, value);
    }

    private static void OnObserveCaretPropertyChanged(DependencyObject dpo, DependencyPropertyChangedEventArgs eventArgs)
    {
        TextBox textBox = dpo as TextBox;
        if (textBox != null)
        {
            if ((bool)eventArgs.NewValue == true)
            {
                textBox.SelectionChanged += textBox_SelectionChanged;
            }
            else
            {
                textBox.SelectionChanged -= textBox_SelectionChanged;
            }
        }
    }

    static void textBox_SelectionChanged(object sender, RoutedEventArgs eventArgs)
    {
        TextBox textBox = sender as TextBox;
        int caretIndex = textBox.CaretIndex;
        SetCaretIndex(textBox, caretIndex);
        SetLineIndex(textBox, textBox.GetLineIndexFromCharacterIndex(caretIndex));
    }

    private static readonly DependencyProperty CaretIndexProperty =
        DependencyProperty.RegisterAttached("CaretIndex", typeof(int), typeof(TextBoxCaretBehaviour));

    /// <summary>
    /// Set caret index.
    /// </summary>
    /// <param name="element">The element.</param>
    /// <param name="value">The value.</param>
    public static void SetCaretIndex(DependencyObject element, int value)
    {
        element.SetValue(CaretIndexProperty, value);
    }

    /// <summary>
    /// Get caret index.
    /// </summary>
    /// <param name="element">The element.</param>
    /// <returns>The get caret index result.</returns>
    public static int GetCaretIndex(DependencyObject element)
    {
        return (int)element.GetValue(CaretIndexProperty);
    }

    private static readonly DependencyProperty LineIndexProperty =
        DependencyProperty.RegisterAttached("LineIndex", typeof(int), typeof(TextBoxCaretBehaviour));

    /// <summary>
    /// Set line index.
    /// </summary>
    /// <param name="element">The element.</param>
    /// <param name="value">The value.</param>
    public static void SetLineIndex(DependencyObject element, int value)
    {
        element.SetValue(LineIndexProperty, value);
    }

    /// <summary>
    /// Get line index.
    /// </summary>
    /// <param name="element">The element.</param>
    /// <returns>The get line index result.</returns>
    public static int GetLineIndex(DependencyObject element)
    {
        return (int)element.GetValue(LineIndexProperty);
    }
}