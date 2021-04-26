using System.Windows;
using System.Windows.Controls;

namespace Messil
{

    /// <summary>
    /// The IsBusy attached property for anthyng that can be busy
    /// </summary>
    public class IsFocusedProperty : BaseAttachedProperty<IsFocusedProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (!(sender is Control control))
                return;


            control.Loaded += (s, se) => control.Focus();
        }
    }
}