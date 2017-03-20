using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Patterns;
using PureMVC.Interfaces;

namespace Prototype
{
    public class PrototypeSimpleCommnad : SimpleCommand, ICommand
    {
        public override void Execute(INotification note)
        {
            //Proxys
            Facade.RegisterProxy(new PrototypeProxy(PrototypeFacade.ProxyDefine.PrototypeProxy));

            //Mediators
            Facade.RegisterMediator(new PrototypeSceneMediator(((Entry)note.Body).prototypeSceneView, PrototypeFacade.MediatorDefine.PrototypeMediator));

            //Command
            Facade.RegisterCommand(PrototypeFacade.CommandDefine.PrototypeSimpleCommnad, typeof(PrototypeSimpleCommnad));
        }
    }
}
