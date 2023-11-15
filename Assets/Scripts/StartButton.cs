using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject deactivateObject;
    public Controllable c1,c2,c3,c4,c5;
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            deactivateObject.SetActive(false);
            c1.enabled = false;
            c2.enabled = false;
            c3.enabled = false;
            c4.enabled = false;
            c5.enabled = false;
        }
    }
}
