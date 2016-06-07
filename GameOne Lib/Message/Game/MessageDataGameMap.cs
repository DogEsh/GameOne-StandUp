using System;
using SimpleTeam.Message;
using SimpleTeam.GameOne.Parameter;
using SimpleTeam.GameOne.GameInfo;

namespace SimpleTeam.GameOne.Message
{
    using ParameterID = Byte;
    using MessageID = Byte;

    [Serializable]
    public sealed class MessageDataGameMap : IMessageData
    {
        public MessageID Type
        {
            get
            {
                return (MessageID)HelperMessageID.GameMap;
            }
        }
        public ParameterID ParameterType
        {
            get
            {
                return (ParameterID)HelperParameterID.SceneGame;
            }
        }

        public MessageDataGameMap(IMapInfo mapInfo)
        {
            _mapInfo = mapInfo;
        }
        private IMapInfo _mapInfo;
        public IMapInfo MapInfo
        {
            get
            {
                return _mapInfo;
            }
        }
    }
}
