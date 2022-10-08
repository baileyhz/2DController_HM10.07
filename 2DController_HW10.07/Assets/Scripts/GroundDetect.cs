using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetect : MonoBehaviour
{
    
   
    public bool IsGround;

    

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Ground")
            IsGround = true;
        Debug.Log(IsGround);
    }
    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Ground")
            IsGround = false;
        Debug.Log(IsGround);
    }


}
