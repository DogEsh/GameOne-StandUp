using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTeam.GameOne.GameInfo
{
    using GameObjID = UInt16;
    public interface IGameObjID
    {
        GameObjID ID { get; }
    }
}
