using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{
    public class PrototypeSceneView : MonoBehaviour
    {
        public SpriteRenderer spriteRenderer_001;
        public SpriteRenderer spriteRenderer_002;
        public SpriteRenderer spriteRenderer_003;
        public SpriteRenderer spriteRenderer_004;



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
            if(clickFlag == true)
            {
                clickFlag = false;
                Show();
            }
            else
            {
                clickFlag = true;
                Hide();
            }
        }

        public void Show()
        {
            spriteRenderer_001.enabled = true;
            spriteRenderer_002.enabled = true;
            spriteRenderer_003.enabled = true;
            spriteRenderer_004.enabled = true;
        }

        public void Hide()
        {
            spriteRenderer_001.enabled = false;
            spriteRenderer_002.enabled = false;
            spriteRenderer_003.enabled = false;
            spriteRenderer_004.enabled = false;
        }
    }
}
