using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour
{
    public GameObject Bulb;
    private bool isOn = false;
    private Animator bulbAnimator;
    switchOff.GetComponent<ManualSwitchController>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SwitchLightOn()
        SwitchLightOff()

    }
    
   
 
    void SwitchLightOn()
    { 
       if switchOff == true && isOn == false
        {

            bulbAnimator.SetBool("IsSwitchOn", true);
            isOn = true
        }
    }

    void SwitchLightOff()
    { 
      if switchOff == false && isOn == true
       {
           bulbAnimator.SetBool("IsSwitchOn", true);
           isOn = true
       }
    }


}
