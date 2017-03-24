using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Init  
{
    public class InitSceneView : MonoBehaviour
    {
        public Text initText;
        public Button initCompleteButton;




        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnInitialCompleteClick()
        {
            InitSceneMediator.delOnInitialCompleteClick();
        }
    }
}
