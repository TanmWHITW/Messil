using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messil.Core
{
    public class ApplicationViewModel: BaseViewModel
    {

        public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.Login;

        public bool SideBarVisible { get; set; } = false;

        public void GoToPage(ApplicationPage page)
        {
            CurrentPage = page;

            SideBarVisible = page == ApplicationPage.Chat;
        }
    }
}
