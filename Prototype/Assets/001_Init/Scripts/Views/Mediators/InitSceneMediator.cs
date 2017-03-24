using System.Collections.Generic;
using UnityEngine;

using PureMVC.Patterns;
using PureMVC.Interfaces;



namespace Init
{
    public class InitSceneMediator : Mediator, IMediator
    {
        private InitSceneView initSceneView;


        public InitSceneMediator(InitSceneView initSceneView, string name) : base(name, initSceneView)
		{
            this.initSceneView = ((InitSceneView)m_viewComponent);

            #region CallBack
            delOnInitialCompleteClick = OnInitialCompleteClick;
            #endregion
        }

        #region CallBack
        public delegate void DelOnInitialCompleteClick();
        public static DelOnInitialCompleteClick delOnInitialCompleteClick;
        public void OnInitialCompleteClick()
        {
            Debug.Log("InitSceneMediator - OnInitialCompleteClick");
            initSceneView.initText.text = "Init Complete";
        }
        #endregion




        public override IList<string> ListNotificationInterests()
        {
            IList<string> list = new List<string>();
            list.Add(InitFacade.NotifyDefine.InitNotify);
            return list;
        }

        public override void HandleNotification(INotification note)
        {
            switch (note.Name)
            {
                case InitFacade.NotifyDefine.InitNotify:
                    {
                      
                   
                    }
                    break;
            }
        }
    }
}
