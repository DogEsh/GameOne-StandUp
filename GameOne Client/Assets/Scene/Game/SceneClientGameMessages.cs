using SimpleTeam.Command.Scenario;

namespace SimpleTeam.GameOne.Scene
{
    class SceneClientGameMessages : SceneMessages
    {
        public SceneClientGameMessages(IScenario scenario)
        {
            base.Add(new MessageHandlerClientGameMap(scenario));
            base.Add(new MessageHandlerClientGameState(scenario));
        }

    }
}
