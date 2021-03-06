﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Core;
using PureMVC.Interfaces;
using PureMVC.Patterns;

namespace Init
{
    public class DebugMediator : Mediator, IMediator
    {
        public DebugMediator(DebugView debugView, string name) : base(name, debugView)
        {

        }

        public override IList<string> ListNotificationInterests()
        {
            IList<string> list = new List<string>();
            list.Add(InitFacade.NotifyDefine.DebugNotify);
            return list;
        }

        public override void HandleNotification(INotification note)
        {
            switch (note.Name)
            {
                case InitFacade.NotifyDefine.DebugNotify:
                    {


                    }
                    break;
            }
        }
    }
}
