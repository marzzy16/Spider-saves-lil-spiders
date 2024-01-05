using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Transform destination;

   public Transform Getdestination()
    {
        return destination;
    }
}
