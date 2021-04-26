using System;
using System.Collections.Generic;

namespace Messil.Core
{
    /// <summary>
    /// The design-time data for a <see cref="ChatListViewModel"/>
    /// </summary>
    public class ChatMessageListDesignModel : ChatMessageListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatMessageListDesignModel Instance => new ChatMessageListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatMessageListDesignModel()
        {
            Items = new List<ChatMessageListItemViewModel>
            {
                new ChatMessageListItemViewModel
                {
                    SenderName = "World Web",
                    Message = "Сервер снова работает",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SendByMe = false,
                },
                new ChatMessageListItemViewModel
                {
                    SenderName = "Developer",
                    Message = "Какой IP адрес сервера? Он изменился?",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    MessageReadTime = DateTimeOffset.UtcNow,
                    SendByMe = true,
                },
                
            };
        }

        #endregion
    }
}
