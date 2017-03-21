using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Patterns;
using PureMVC.Interfaces;

namespace Prototype
{
    public class PrototypeSimpleCommnad : SimpleCommand, ICommand
    {
        private Entry entry;

        public override void Execute(INotification notification)
        {
            //REF
            entry = (Entry)notification.Body;

            //Proxy
            Facade.RegisterProxy(new PrototypeProxy(PrototypeFacade.ProxyDefine.PrototypeProxy));

            //Mediator
            Facade.RegisterMediator(new PrototypeSceneMediator(entry.prototypeSceneView, PrototypeFacade.MediatorDefine.PrototypeMediator));

            //Command
            Facade.RegisterCommand(PrototypeFacade.CommandDefine.PrototypeMacroCommnad, typeof(PrototypeMacroCommnad));


            Debug.Log("PrototypeSimpleCommnad");
        }
    }
}
