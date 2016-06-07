using SimpleTeam.GameOne.GameInfo;
using System.Collections.Generic;
using System;

namespace Assets.Scene.Game.New
{
    using GameObjID = UInt16;
    class SceneGameMap
    {
        private IMapInfo _mapInfo;
        private Dictionary<GameObjID, ISimplus> _simpluses = null;
        public void SetToInitMap(IMapInfo mapInfo)
        {
            _mapInfo = mapInfo;
            ClearMap();
            InitMap();
            UpdateMap();
        }
        public void SetToUpdateMap(IMapInfo mapInfo)
        {
            _mapInfo = mapInfo;
        }
      
        private void UpdateMap()
        {

        }
        private void InitMap()
        {
            foreach(ISimplusInfo s in _mapInfo.GetContainerSimplus())
            {
                _simpluses.Add(s.ID,s);
            }
            


        }
        private void ClearMap()
        {
            if (_simpluses != null)
            {
                foreach (ISimplus s in _simpluses.Values)
                {
                    s.Destroy();
                }
            }
            _simpluses = new Dictionary<GameObjID, ISimplus>();
        }
    }
}
