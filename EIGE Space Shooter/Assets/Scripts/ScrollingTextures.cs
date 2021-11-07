using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingTextures : MonoBehaviour
{
   

    
    public float verticalScrollSpeed;
    public Material background;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float offset = Time.time * verticalScrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }

    //public void Update()
    //{
    //    background.SetTextureOffset("Stars", new Vector2(0, Time.time * verticalScrollSpeed));
    //}

    

}
