namespace Messil.Core
{
    /// <summary>
    /// a view model for every Chat list item
    /// </summary>
    public class ChatListItemViewModel
    {

        public string Name { get; set; }

        public string Message { get; set; }

        public string Initials { get; set; }

        public string ProfilePictureRGB { get; set; }

        public bool NewContentAvailable { get; set; }

        public bool IsSelected { get; set; }
    }
}
