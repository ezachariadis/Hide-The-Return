using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtendingMono : MonoBehaviour {

    GameObject GameObj;
    Transform GOTransform;
    string GameobjTag;


    public virtual void Init()
    {
        GameObj = this.gameObject;
        GOTransform = this.transform;
        GameobjTag = this.gameObject.tag;
    }
}
