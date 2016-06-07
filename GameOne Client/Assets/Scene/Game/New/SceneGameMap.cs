using SimpleTeam.GameOne.GameInfo;
using System.Collections.Generic;

namespace Assets.Scene.Game.New
{
    class SceneGameMap
    {
        private IMapInfo _mapInfo;
        private Dictionary<>
        public void SetToInitMap(IMapInfo mapInfo)
        {
            _mapInfo = mapInfo;
            InitMap();
            UpdateMap();
        }
        public void SetToUpdateMap(IMapInfo mapInfo)
        {
            _mapInfo = mapInfo;
        }
        private void InitMap()
        {

        }
        private void UpdateMap()
        {

        }

    }
}
