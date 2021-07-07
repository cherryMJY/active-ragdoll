using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public Animator anim;
    public GameObject com;
    public Transform cam;
    public HingeJoint leftLeg, rightLeg,leftUpLeg,rightUpLeg;
    // Start is called before the first frame update
    void Start()
    {

    }

    private string frontState, nowState;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {   
            nowState = "W";
            //com.transform.rotation = Quaternion.LookRotation(cam.forward);
            com.transform.forward = Vector3.Slerp(com.transform.forward, (cam.forward).normalized, Time.deltaTime * 20);
        }
        if (Input.GetKey(KeyCode.A))
        {
            nowState = "A";
            //com.transform.rotation = Quaternion.LookRotation(-cam.right);
            com.transform.forward = Vector3.Slerp(com.transform.forward, (-cam.right).normalized, Time.deltaTime * 20);
        }
        if (Input.GetKey(KeyCode.S))
        {
            nowState = "S";
            // com.transform.rotation = Quaternion.LookRotation(-cam.forward);
            // com.transform.forward = Vector3.Slerp(com.transform.forward, (-cam.forward ).normalized, Time.deltaTime * 50);
            com.transform.forward = Vector3.Slerp(com.transform.forward, (-cam.forward).normalized, Time.deltaTime * 20);
        }
        if (Input.GetKey(KeyCode.D))
        {
            nowState = "D";
            //com.transform.rotation = Quaternion.LookRotation(cam.right);
            com.transform.forward = Vector3.Slerp(com.transform.forward, (cam.right).normalized, Time.deltaTime * 20);
        }



        //hingeJoint.spring.targetPosition = 70;
        Debug.Log(""+ leftUpLeg.spring.targetPosition+"  "+ rightUpLeg.spring.targetPosition);

        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D))
        {
            anim.Play("idle");
            leftLeg.useSpring = true; rightLeg.useSpring = true;
        }
        else
        {
            anim.Play("walk");
            //是要右脚走的时候 左脚用力  
            //左脚走的时候 右脚用力
            
            
            
            if (leftUpLeg.spring.targetPosition < 0)
                leftLeg.useSpring = false;
            else
                leftLeg.useSpring = true;
            if (rightUpLeg.spring.targetPosition < 0)
                rightLeg.useSpring = false;
            else
                rightLeg.useSpring = true;
             

            //leftLeg.useSpring = false; rightLeg.useSpring = false;

            //leftLeg.useSpring = true; rightLeg.useSpring = true;
        }
        //走完一步以后要恢复平衡
    }
}
