using System.Windows;
using System.Windows.Controls;

namespace Messil
{

    /// <summary>
    /// The NoHistory attached property for any frame to hide the navvigation
    /// </summary>
    public class NoFrameHistory : BaseAttachedProperty<NoFrameHistory, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var frame = (sender as Frame);

            frame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;

            frame.Navigated += (ss, ee) => ((Frame)ss).NavigationService.RemoveBackEntry();
        }
    }
}