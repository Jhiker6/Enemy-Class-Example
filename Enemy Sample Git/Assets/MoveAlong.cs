using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAlong : MonoBehaviour
{
    // Update is called once per frame
    void LateUpdate()
    {
        CountItHigher cih = this.gameObject.GetComponent<CountItHigher>();
        if (cih != null )        
        {
            Vector3 tempPos = pos;
            tempPos.x = cih.currentNum / 10f;
            pos = tempPos;
        }
    }

    public Vector3 pos
    {
        get { return(this.transform.position); }
        set { this.transform.position = value; }
    }
}
