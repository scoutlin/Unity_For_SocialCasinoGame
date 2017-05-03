using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Patterns;
using PureMVC.Interfaces;

namespace Init
{
    public class InitFacade : Facade, IFacade
    {
        #region Define Classes
        public class ProxyDefine
        {
            public const string InitProxy = "InitProxy";
        }

        public class MediatorDefine
        {
            public const string InitMediator = "InitMediator";
        }

        public class CommandDefine
        {
            public const string InitMacroCommnad = "InitMacroCommnad";
            public const string InitSimpleCommnad = "InitSimpleCommnad";
        }

        public class NotifyDefine
        {
            public const string InitNotify = "InitNotify";

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
                        if (m_instance == null) m_instance = new InitFacade();
                    }
                }

                return m_instance;
            }
        }

        public void PutEntryIn(Entry entry)
        {
            this.entry = entry;
        }

        public void Init()
        {
            RegisterCommand(CommandDefine.InitSimpleCommnad, typeof(PrototypeSimpleCommnad));
            SendNotification(CommandDefine.InitSimpleCommnad, entry, "Entry");
        }
    }
}
