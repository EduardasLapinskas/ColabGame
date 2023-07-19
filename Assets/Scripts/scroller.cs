using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class scroller : MonoBehaviour
{
    //Using raw image UV rect we move the image

    [SerializeField] RawImage _img;
    [SerializeField] float _x, _y;

    void Update()
    {
        _img.uvRect = new Rect(_img.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, _img.uvRect.size);
    }

}
