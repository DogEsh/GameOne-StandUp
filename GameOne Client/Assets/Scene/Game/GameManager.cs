using System;
using SimpleTeam.Message;
using UnityEngine;
using SimpleTeam.GameOne.Message;
using SimpleTeam.GameOne.GameInfo;


namespace SimpleTeam.GameOne.Scene
{
    using GameID = UInt16;
    class GameManager : MonoBehaviour
    {


        private MouseManager _mouse = new MouseManager();
        public LinkManager _linkManager;
        public GameMap _map;

    

        public void UpdateLink()
        {
            Simplus simplus = _map.GetFocusedSimplus(_mouse.Pos);
 
            _linkManager.UpdateDraw(simplus, _mouse);
        }



        public void Update()
        {
            _mouse.Update();
            UpdateLink();
        }

    }
}
