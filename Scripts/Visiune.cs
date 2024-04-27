using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visiune : MonoBehaviour
{
    public GameObject target;
    public float xOffset, yOffset, zOffset;
    void Update()
    {
        transform.position = target.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(target.transform.position);
    }
}
