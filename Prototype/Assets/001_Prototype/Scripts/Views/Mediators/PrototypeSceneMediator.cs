using System.Collections.Generic;

using PureMVC.Patterns;
using PureMVC.Interfaces;



namespace Prototype
{
    public class PrototypeSceneMediator : Mediator, IMediator
    {
        public PrototypeSceneMediator(PrototypeSceneView prototypeView, string name) : base(name, prototypeView)
		{

        }

        public override IList<string> ListNotificationInterests()
        {
            IList<string> list = new List<string>();
            list.Add(PrototypeFacade.NotifyDefine.PrototypeNotify);
            return list;
        }

        public override void HandleNotification(INotification note)
        {
            switch (note.Name)
            {
                case PrototypeFacade.NotifyDefine.PrototypeNotify:
                {

                }
                break;
            }
        }
    }
}
