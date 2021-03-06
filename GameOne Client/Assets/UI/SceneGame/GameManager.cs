﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using UnityEngine;
using SimpleTeam.GameOne.Message;
using SimpleTeam.GameOne.GameInfo;


namespace SimpleTeam.GameOne.Scene
{
    using GameObjID = UInt16;
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

        public void SetMap(MessageDataGameMap message)
        {
            ArrayList simplusInfo = new ArrayList();

            SimplusInfo info;
            {
                GameObjID id = 124;
                Circle circle = new Circle(Vector2.zero, 50);
                ISimplusHP hp = new SimplusHP(30);
                IParty party = new Party(0);
                ILinkInfoContainer links = new LinkInfoList();
                info = new SimplusInfo(id, circle, hp, party, links);
            }
        }
    }
}
