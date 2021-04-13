
using System.Collections.Generic;

namespace Messil.Core
{
    /// <summary>
    /// The design-time data for a <see cref="ChatListViewModel"/>
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatListDesignModel Instance => new ChatListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    Initials = "JP",
                    Name = "John",
                    Message = "Привет, Джон",
                    ProfilePictureRGB = "710117",
                    IsSelected = true,
                },
                new ChatListItemViewModel
                {
                    Initials = "AN",
                    Name = "Abstract Name",
                    Message = "Abstract message",
                    ProfilePictureRGB = "E1C340",
                    NewContentAvailable = true,
                },
                new ChatListItemViewModel
                {
                    Initials = "BN",
                    Name = "BN",
                    Message = "Empty message",
                    ProfilePictureRGB = "54627B",
                },
                new ChatListItemViewModel
                {
                    Initials = "WW",
                    Name = "World Web",
                    Message = "Какой IP адрес сервера? Он изменился или нет?",
                    ProfilePictureRGB = "f32c6f",
                    NewContentAvailable = true,
                },
                new ChatListItemViewModel
                {
                    Initials = "II",
                    Name = "Ivan Ivanov",
                    Message = "Иван Иванов",
                    ProfilePictureRGB = "00A8A8",
                    NewContentAvailable = true,
                },
                new ChatListItemViewModel
                {
                    Initials = "AL",
                    Name = "Alphabet",
                    Message = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ",
                    ProfilePictureRGB = "6D0E10",
                },
                new ChatListItemViewModel
                {
                    Initials = "CI",
                    Name = "Crown II",
                    Message = "...",
                    ProfilePictureRGB = "FF8300",
                },
                new ChatListItemViewModel
                {
                    Initials = "KS",
                    Name = "Kirill",
                    Message = "The Developer chats with himself",
                    ProfilePictureRGB = "000000",
                    NewContentAvailable = true,
                },
                new ChatListItemViewModel
                {
                    Initials = "QS",
                    Name = "Queen Standaltfield",
                    Message = "Very very very long text that has ",
                    ProfilePictureRGB = "006D5B",
                },
                new ChatListItemViewModel
                {
                    Initials = "UY",
                    Name = "Uni Yianna",
                    Message = "こんにちは",
                    ProfilePictureRGB = "F8D210",
                    NewContentAvailable = true,
                },
                new ChatListItemViewModel
                {
                    Initials = "MP",
                    Name = "Max",
                    Message = "Hi",
                    ProfilePictureRGB = "2EB5E0",
                },
            };
        }

        #endregion
    }
}
