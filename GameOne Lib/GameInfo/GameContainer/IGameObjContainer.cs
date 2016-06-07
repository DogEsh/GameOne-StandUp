using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTeam.GameOne.GameInfo
{
    using GameObjID = UInt16;
    public interface IGameObjContainer<T> : IEnumerable<T>
        where T : IGameObjID
    {
        T GetObj(GameObjID ID);

        void SetObj(T gameObj);
        int Count { get; }
    }
}
