using Messil.Core;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Messil
{
    /// <summary>
    /// Base functionality for all pages
    /// </summary>
    public class BasePage<VM> : Page
        where VM: BaseViewModel, new()
    {
        #region Private Members

        /// <summary>
        /// The View Model associated with this page
        /// </summary>
        private VM mViewModel;

        #endregion


        #region Public Properties

        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

        public float SlideSeconds { get; set; } = 0.8f;

        public VM ViewModel 
        {
            get { return ViewModel; }
            set
            {
                /// if nothing has changed then return
                if (ViewModel == value)
                    return;

                /// Update our value
                mViewModel = value;

                /// Set the DataContext for this page
                DataContext = mViewModel;
            }
        }

        #endregion

        #region Constructor

        public BasePage()
        {
            if (PageLoadAnimation != PageAnimation.None)
                Visibility = Visibility.Collapsed;

            /// Listen out for the page loading
            Loaded += BasePage_Loaded;

            /// Create a default View Model
            DataContext = new VM();
        }


        #endregion

        #region Animation Load or Unload

        private async void BasePage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            await AnimateInAsync();
        }

        public async Task AnimateInAsync()
        {
            if (PageLoadAnimation == PageAnimation.None)
                return;

            switch (PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:

                    await this.SlideAndFadeInFromRightAsync(SlideSeconds);

                    break;
            }
        }

        public async Task AnimateOutAsync()
        {
            if (PageUnloadAnimation == PageAnimation.None)
                return;

            switch (PageUnloadAnimation)
            {
                case PageAnimation.SlideAndFadeOutToLeft:

                    await this.SlideAndFadeOutToLeftAsync(SlideSeconds);

                    break;
            }
        }

        #endregion
    }
}
