using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{
    [SerializeField] Transform player;

    void FixedUpdate()
    {
        // CHALLENGE: This could be more efficient
        GameObject moveTowardsThis = GameObject.FindWithTag("Player");
        transform.position = Vector3.MoveTowards(transform.position, moveTowardsThis.transform.position, 0.005f);
    }
}
