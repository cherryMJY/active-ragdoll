using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balance : MonoBehaviour
{
    public Transform body;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = body.position;
    }

    // Update is called once per frame
    void Update()
    {
        //自己的位置 = 身体的位置 
        Debug.Log("bodypos"  + body.position);
        transform.position = body.position + new Vector3(0f,0.2f,0f);
        Debug.Log("transpos" + transform.position);
    }
}
