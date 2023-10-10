using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * 0.02f, Input.GetAxis("Vertical") * 0.02f, 0);
    }
}
