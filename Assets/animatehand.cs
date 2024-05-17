using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class animatehand : MonoBehaviour
{
    public InputActionProperty grabanim;
    public Animator handanim;

    private void Update()
    {
        float gripvalue = grabanim.action.ReadValue<float>();
        handanim.SetFloat("Grip", gripvalue);
    }
}
