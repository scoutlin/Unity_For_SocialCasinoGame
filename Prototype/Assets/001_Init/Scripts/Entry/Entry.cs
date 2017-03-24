using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PureMVC.Core;
using PureMVC.Patterns;

namespace Init
{
    public class Entry : MonoBehaviour
    {
        public InitSceneView initSceneView;

        void Awake()
        {
            InitFacade initFacade = (InitFacade)InitFacade.Instance;
            initFacade.PutEntryIn(this);
            initFacade.Init();
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
