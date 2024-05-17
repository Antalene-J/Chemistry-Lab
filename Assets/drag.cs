using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour {

    
    Vector3 mousePostionOffset;

    private Vector3 GetmousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown() 
    {
        mousePostionOffset = gameObject.transform.position - GetmousePos();
    }

    private void OnMouseDrag() 
    { 
        transform.position = GetmousePos() + mousePostionOffset;
    } 
}
