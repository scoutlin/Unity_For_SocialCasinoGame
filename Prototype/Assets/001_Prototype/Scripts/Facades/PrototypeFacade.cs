using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Patterns;
using PureMVC.Interfaces;

namespace Prototype
{
    public class PrototypeFacade : Facade
    {
        #region Classes
        public class ProxyDefine
        {
            public const string PrototypeProxy = "PrototypeProxy";
        }

        public class MediatorDefine
        {
            public const string PrototypeMediator = "PrototypeMediator";
        }

        public class CommandDefine
        {
            public const string PrototypeMacroCommnad = "PrototypeMacroCommnad";
            public const string PrototypeSimpleCommnad = "PrototypeSimpleCommnad";
        }

        public class NotifyDefine
        {
            public const string PrototypeNotify = "PrototypeNotify";
        }
        #endregion




        private Entry entry;


        /// <summary>
        /// Facade Singleton Factory method.  This method is thread safe.
        /// </summary>
        public new static IFacade Instance
        {
            get
            {
                if (m_instance == null)
                {
                    lock (m_staticSyncRoot)
                    {
                        if (m_instance == null) m_instance = new PrototypeFacade();
                    }
                }

                return m_instance;
            }
        }

        public void PutEntryIn(Entry entry)
        {
            this.entry = entry;
        }

        public void RegistComponent()
        {
            RegisterProxy(new PrototypeProxy(ProxyDefine.PrototypeProxy));

            RegisterMediator(new PrototypeSceneMediator(entry.prototypeSceneView, MediatorDefine.PrototypeMediator));

            RegisterCommand(CommandDefine.PrototypeSimpleCommnad, typeof(PrototypeSimpleCommnad));
            RegisterCommand(CommandDefine.PrototypeMacroCommnad, typeof(PrototypeMacroCommnad));
        }
    }
}
