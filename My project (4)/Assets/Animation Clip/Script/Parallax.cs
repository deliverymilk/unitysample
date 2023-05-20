using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour
{
    [SerializeField] Rect rect;
    [SerializeField] RawImage rawImage;

    [SerializeField] float speed = 0.25f;

 
    // Update is called once per frame
    void Update()
    {
        rect = rawImage.uvRect;

        //V=v0+vt
        rect.x += speed * Time.deltaTime;

        rawImage.uvRect = rect;
    }
}
