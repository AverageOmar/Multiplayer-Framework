using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public enum PacketType
    {
        EMPTY,
        NICKNAME,
        CHATMESSAGE,
    }

    [Serializable]
    public class Packet
    {
        public PacketType type = PacketType.EMPTY;
    }

    [Serializable]
    public class ChatMessagePacket : Packet
    {
        public string _Message;

        public ChatMessagePacket(string message)
        {
            
            _Message = message;
            this.type = PacketType.CHATMESSAGE;
        }
    }

    [Serializable]
    public class NickNamePacket : Packet
    {
        public string _NickName;

        public NickNamePacket(string nickname)
        {
            _NickName = nickname;
            this.type = PacketType.NICKNAME;
        }
    }
}
