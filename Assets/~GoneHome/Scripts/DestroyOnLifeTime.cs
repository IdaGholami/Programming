using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoneHome
{
    public class DestroyOnLifeTime : MonoBehaviour
    {
        public float LifeTime = 5f;

        // Use this for initialization
        void Start()
        {
            Destroy(gameObject, LifeTime);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
