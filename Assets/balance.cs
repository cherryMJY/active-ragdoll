using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balance : MonoBehaviour
{
    public Transform body;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = body.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = body.position;
    }
}
