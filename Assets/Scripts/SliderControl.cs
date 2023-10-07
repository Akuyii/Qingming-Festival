using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityVolumeRendering
{
    public class SliderControl : MonoBehaviour
    {
        private Slider slider;
        private Transform sphere;
        private Removable removable;
        public Transform text;
        public float textPoint_num;
        private float text_y;

        //public void SetValue(float value)
        //{
        //    slider = GetComponent<Slider>();
        //    slider.value = value;
        //    sphere = transform.GetChild(0);
        //    sphere.localPosition = new Vector3(value * 140 - 70, 0, 0);
        //}
        // Use this for initialization
        void Start()
        {
            slider = GetComponent<Slider>();
            Debug.Log(slider.value);
            sphere = transform.GetChild(0);
            Debug.Log(sphere.name);
            removable = sphere.GetComponent<Removable>();
            //sphere.localPosition = Vector3.zero;

            //slider.value = (float)0;
        }

        // Update is called once per frame
        void Update()
        {
            if (sphere.localPosition.y >= 70)
            {
                slider.value = 0f;
            }
            else if (sphere.localPosition.y <= -70)
            {
                slider.value = 1f;
            }
            else
            {
                slider.value = 1 - (sphere.localPosition.y + 70) / 140;
            }

            //slider.value = Mathf.Clamp((1 - (sphere.localPosition.y + 70) / 140), 0, 1);

            if(sphere.localPosition.y<=70&& sphere.localPosition.y >= -70)
            {
                //text_y = textPoint_num + (slider.value * textPoint_num * 2);
                text_y = textPoint_num - (slider.value * textPoint_num * 2);
                text.localPosition = new Vector3(0, -text_y, 0);
            }
            

            //if (!removable.moving)
            //{

            //    if (sphere.localPosition.y >= 70)
            //    {
            //        sphere.localPosition = new Vector3(70, 0, 0);
            //    }
            //    else if (sphere.localPosition.y <= -150)
            //    {
            //        sphere.localPosition = new Vector3(-70, 0, 0);
            //    }
            //    else
            //    {
            //        sphere.localPosition = new Vector3(0, sphere.localPosition.y, 0);
            //    }
            //}
        }
    }
}
