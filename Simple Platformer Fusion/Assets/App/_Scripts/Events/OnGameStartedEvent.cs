using DynamicBox.EventManagement;
using Fusion;

namespace Javid.Events
{
    public class OnGameStartedEvent : GameEvent
    {
        public readonly string NickName;
        public readonly string RoomName;
        public GameMode Mode;

        public OnGameStartedEvent(string nickname, string roomName, GameMode mode)
        {
            NickName = nickname;
            RoomName = roomName;
            Mode = mode;
        }
    }
}