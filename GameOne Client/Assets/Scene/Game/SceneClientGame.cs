﻿using UnityEngine;
using SimpleTeam.Command;
using System;
using SimpleTeam.Command.Scenario;
using SimpleTeam.GameOne.Message;
using SimpleTeam.Message;

namespace SimpleTeam.GameOne.Scene
{
    public class SceneClientGame : MonoBehaviour, ISceneGame
    {
        //ISceneScenario
        private ISceneScenario _sceneScenario;

        public IScenario GetScenario()
        {
            return _sceneScenario.GetScenario();
        }

        //ISceneMessages
        private ISceneMessages _sceneMessages;
        public void SetMessage(IMessage message)
        {
            _sceneMessages.SetMessage(message);
        }

        public void Start()
        {
            _sceneScenario = new SceneScenario();
            _sceneMessages = new SceneClientGameMessages(_sceneScenario.GetScenario());

        }

       
    }
}
