namespace Bridge.Html5
{
    /// <summary>
    /// The DOM CompositionEvent represents events that occur due to the user indirectly entering text.
    /// </summary>
    [Ignore]
    [Name("CompositionEvent")]
    public class CompositionEvent : UIEvent
    {
        private CompositionEvent()
        {
        }

        /// <summary>
        /// For compositionstart events, this is the currently selected text that will be replaced by the string being composed. This value doesn't change even if content changes the selection range; rather, it indicates the string that was selected when composition started.
        /// For compositionupdate, this is the string as it stands currently as editing is ongoing.
        /// For compositionend events, this is the string as committed to the editor.
        /// </summary>
        public readonly string Data;

        /// <summary>
        /// The locale of current input method (for example, the keyboard layout locale if the composition is associated with IME).
        /// </summary>
        public readonly string Locale;
    }
}
