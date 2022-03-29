using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ShieldBP : MonoBehaviour
{
public SteamVR_ActionSet actionSet;
    
    // Start is called before the first frame update
    public SteamVR_Action_Boolean actionReset = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("buggy", "GrabGrip");

    public SteamVR_Input_Sources hand;

    public Renderer rend;


    void Start()
    {
        actionSet.Activate(hand);
        rend = GetComponent<Renderer>();
        rend.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        if(actionReset.GetStateDown(hand)){
            
            rend.enabled=!rend.enabled;
        }

    }
}
