using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Patterns;
using PureMVC.Interfaces;

namespace Prototype
{
    public class PrototypeProxy : Proxy, IProxy
    {
        public PrototypeProxy(string name) : base(name, new PrototypeDO())
		{

        }
    }
}
