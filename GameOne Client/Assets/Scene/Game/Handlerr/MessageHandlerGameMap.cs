using System;
using SimpleTeam.GameOne.Message;
using SimpleTeam.Command.Scenario;
using SimpleTeam.Message;

namespace SimpleTeam.GameOne.Scene
{
    using MessageID = Byte;
    class MessageHandlerClientGameMap : IMessageHandler
    {
        public MessageID Type
        {
            get
            {
                return (MessageID)HelperMessageID.GameMap;
            }
        }
        MessageHandlerScenario _handlerScenario;
        public MessageHandlerClientGameMap(IScenario scenario)
        {
            _handlerScenario = new MessageHandlerScenario(scenario);
        }

        public void SetMessage(IMessage message)
        {
            MessageDataGameMap data = message as IMessageData as MessageDataGameMap;
        }
    }
}

