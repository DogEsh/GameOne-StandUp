using System.Collections.Generic;
using System;

namespace SimpleTeam.GameOne.GameInfo
{
    using GameObjID = UInt16;
    public interface ILinkInfoContainer : IGameObjContainer<ISimplusLinkInfo>
    {
        int MaxCount { get; }
    }
}
