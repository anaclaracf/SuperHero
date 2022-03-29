// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class LaserActivate : MonoBehaviour
// {
//     public SteamVR_ActionSet actionSet;
    
//     public SteamVR_Action_Single actionThrottle = SteamVR_Input.GetAction<SteamVR_Action_Single>("buggy", "Throttle");

//     // Start is called before the first frame update
//     public SteamVR_Action_Boolean actionReset = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("buggy", "Reset");
//     SteamVR_Behaviour_Pose trackedObj;

//     public SteamVR_Input_Sources hand;
//     // Start is called before the first frame update
//     void Start()
//     {
//         actionSet.Activate(hand);
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         print(actionReset.GetStateDown(hand));
//         float throttle = actionThrottle.GetAxis(hand);
//     }
// }
