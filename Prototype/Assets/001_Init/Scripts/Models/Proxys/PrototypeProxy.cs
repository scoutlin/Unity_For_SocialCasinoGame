using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Patterns;
using PureMVC.Interfaces;

namespace Init
{
    public class PrototypeProxy : Proxy, IProxy
    {
        private PrototypeDO prototypeDO;

        public PrototypeProxy(string name) : base(name, new PrototypeDO())
		{
            prototypeDO = (PrototypeDO)Data;
        }

        public string GetUserName()
        {
            return prototypeDO.userData.name;
        }

        public int GetUserAge()
        {
            return prototypeDO.userData.age;
        }
    }
}
