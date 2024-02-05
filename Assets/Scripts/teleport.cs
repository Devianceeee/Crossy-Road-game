using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform teleport_coordinate;
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleport_coordinate.transform.position;
    }
}
