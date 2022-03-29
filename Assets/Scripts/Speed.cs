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

    Vector3 direcao;

    // SteamVR_Behaviour_Pose trackedObj;
GameObject hand ;
    // Start is called before the first frame update
    void Start()
    {
        // trackedObj = GetComponent<SteamVR_Behaviour_Pose>();
        rb = GetComponent<Rigidbody>();

        hand = GameObject.Find("RightHand");

// PEGAR o RIGID BODY rg getcomponenet rigidbody

    }

    void Update()
    {
        if(GetComponent<FixedJoint>() != null){
            direcao = hand.transform.;
        }

        //print(transform.parent);

        // if(botao.GetStateUp(trackedObj.inputSource)){
        //     transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        // }


        // PEGAR O PARENT E CHECAR O NOME 

        

        //Vector3 vel = rb.velocity;
        //if(rb.transform.parent == null){
            rb.velocity = direcao * MoveSpeed;
        //}

        // rb.velocity (transform.forward * 100);

    }

    void HandAttachedUpdate(Hand hand)
    {
        //print("largou"); 
        //transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
    }
}