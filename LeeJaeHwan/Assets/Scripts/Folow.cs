using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Folow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    private void Update()
    {
        this.transform.position = target.position + offset;
    }
}
