using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Core;
using PureMVC.Patterns;

namespace Prototype
{
    public class Entry : MonoBehaviour
    {
        #region All Views
        public PrototypeSceneView prototypeSceneView;
        #endregion




        private bool isStarted = false;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(this.isStarted == false)
            {
                this.isStarted = true;
                PrototypeFacade prototypeFacade = (PrototypeFacade)PrototypeFacade.Instance;
                prototypeFacade.PutEntryIn(this);
                prototypeFacade.RegistComponent();

                Debug.Log("Entry Into Update!!");
            }
        }
    }
}
