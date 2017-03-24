using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Patterns;
using PureMVC.Interfaces;

namespace Init
{
    public class PrototypeSimpleCommnad : SimpleCommand, ICommand
    {
        private Entry entry;

        public override void Execute(INotification notification)
        {
            //REF
            entry = (Entry)notification.Body;

            //Proxy
            Facade.RegisterProxy(new InitProxy(InitFacade.ProxyDefine.InitProxy));

            //Mediator
            Facade.RegisterMediator(new InitSceneMediator(entry.initSceneView, InitFacade.MediatorDefine.InitMediator));

            //Command
            Facade.RegisterCommand(InitFacade.CommandDefine.InitMacroCommnad, typeof(InitMacroCommnad));


            Debug.Log("PrototypeSimpleCommnad");
        }
    }
}
