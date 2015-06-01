using UnityEngine;
using System.Collections;

public class AutoSpinObject : MonoBehaviour {

    public Vector3 spinVector = new Vector3(1, 0, 0);
    private Transform myTransform;
    void Start ( ) {
        myTransform = transform;
    }
    void Update ( ) {
        myTransform.Rotate(spinVector * Time.deltaTime);
    }
}
