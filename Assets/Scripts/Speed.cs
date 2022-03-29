using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Speed : MonoBehaviour
{
    // public SteamVR_Action_Boolean botao = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("InteractUI");
    // FixedJoint joint = null;
    public Rigidbody rb;
    public float MoveSpeed = 3.0f;
    // SteamVR_Behaviour_Pose trackedObj;

    // Start is called before the first frame update
    void Start()
    {
        // trackedObj = GetComponent<SteamVR_Behaviour_Pose>();
        rb = GetComponent<Rigidbody>();

// PEGAR o RIGID BODY rg getcomponenet rigidbody

    }

    // Update is called once per frame
    void Update()
    {
        // if(botao.GetStateUp(trackedObj.inputSource)){
        //     transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        // }


        // PEGAR O PARENT E CHECAR O NOME 
        Vector3 vel = rb.velocity;
        if(rb.transform.parent == null){
            rb.velocity = transform.forward * MoveSpeed;
        }

        // rb.velocity (transform.forward * 100);

    }

    void HandAttachedUpdate(Hand hand)
    {
        //print("largou"); 
        //transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
    }
}