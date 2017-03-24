using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Patterns;
using PureMVC.Interfaces;

namespace Init
{
    public class InitProxy : Proxy, IProxy
    {
        private InitDO initDO;

        public InitProxy(string name) : base(name, new InitDO())
		{
            initDO = (InitDO)Data;
        }

        public string GetUserName()
        {
            return initDO.userData.name;
        }

        public int GetUserAge()
        {
            return initDO.userData.age;
        }
    }
}
