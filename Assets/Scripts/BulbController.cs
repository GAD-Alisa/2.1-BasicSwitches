using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour
{
    public GameObject Bulb;
    public bool isOn;
    private Animator bulbAnimator;
    

    // Start is called before the first frame update
     void Awake()
    {
        bulbAnimator = gameObject.GetComponent<Animator>();
        turnOff();
    }
    void Start()
    {

    }

    
   
 
    void turnOn()
    { 
      

        bulbAnimator.SetBool("IsSwitchOn", true);
        isOn = true;
      
    }

    void turnOff()
    { 
      
           bulbAnimator.SetBool("IsSwitchOn", false);
        isOn = false;
      
    }


}
