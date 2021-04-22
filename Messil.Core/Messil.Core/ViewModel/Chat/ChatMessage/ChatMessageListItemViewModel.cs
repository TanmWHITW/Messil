using System;

namespace Messil.Core
{
    /// <summary>
    /// a view model for every Chat list item
    /// </summary>
    public class ChatMessageListItemViewModel
    {

        public string SenderName { get; set; }

        public string Message { get; set; }

        public bool NewContentAvailable { get; set; }

        public bool IsSelected { get; set; }

        public bool IsTheLastMessage { get; set; }

        public bool SendByMe { get; set; }

        public DateTimeOffset MessageReadTime { get; set; }

        public bool MessageRead => MessageReadTime > DateTimeOffset.MinValue;

        public DateTimeOffset MessageSentTime { get; set; }
    }
}
