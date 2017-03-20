using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{
    public class PrototypeSceneView : MonoBehaviour
    {
        public SpriteRenderer testCircleView;


        private bool clickFlag = false;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnMouseDown()
        {
            Debug.Log("阿伯!!!");

            if(clickFlag == true)
            {
                clickFlag = false;
                this.Show();
            }
            else
            {
                clickFlag = true;
                this.Hide();
            }
        }

        public void Show()
        {
            this.testCircleView.enabled = true;
        }

        public void Hide()
        {
            this.testCircleView.enabled = false;
        }
    }
}
