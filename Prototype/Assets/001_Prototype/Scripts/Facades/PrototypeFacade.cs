using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Patterns;
using PureMVC.Interfaces;

namespace Prototype
{
    public class PrototypeFacade : Facade
    {
        #region Define Classes
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

            public const string DebugNotify = "DebugNotify";
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
            RegisterCommand(CommandDefine.PrototypeSimpleCommnad, typeof(PrototypeSimpleCommnad));

            SendNotification(CommandDefine.PrototypeSimpleCommnad, entry, "Entry");

            
        }
    }
}
