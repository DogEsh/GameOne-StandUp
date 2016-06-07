using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

namespace SimpleTeam.GameOne.GameInfo
{
    using GameObjID = UInt16;
    public interface IMapInfo
    {
        IGameObjContainer<ISimplusInfo> GetContainerSimplus();
    }
}
