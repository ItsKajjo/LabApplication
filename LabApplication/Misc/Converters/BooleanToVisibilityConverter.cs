using System.Windows;

namespace LabApplication.Misc.Converters
{
    /// <summary>
    /// Инвертирует bool в Visibility
    /// <para>True - Collapsed</para>
    /// <para>False - Visible</para>
    /// </summary>
    public sealed class BooleanToVisibilityConverter : BooleanConverter<Visibility>
    {
        public BooleanToVisibilityConverter() : base(Visibility.Visible, Visibility.Collapsed)
        { }
    }
}
