using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ShieldBP : MonoBehaviour
{
    // Start is called before the first frame update
    public SteamVR_Action_Boolean botao = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("GrabGrip");
    SteamVR_Behaviour_Pose trackedObj;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(botao.GetStateDown(trackedObj.inputSource)){
            transform.this.SetActive(true);
        }
        else{
            transform.this.SetActive(false);
        }
    }
}
