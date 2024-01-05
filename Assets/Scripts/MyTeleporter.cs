using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTeleporter : MonoBehaviour
{
    [SerializeField] private Transform destination;

   public Vector3 GetDestination()
    {
        return destination.position;
    }
}
