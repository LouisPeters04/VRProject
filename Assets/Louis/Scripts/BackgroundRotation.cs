using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRotation : MonoBehaviour
{
    public Transform target;
    void Start()
    {
        transform.rotation = target.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = target.rotation;
    }
}
