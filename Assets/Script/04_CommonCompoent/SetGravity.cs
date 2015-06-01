using UnityEngine;
using System.Collections;

public class SetGravity : MonoBehaviour {

    public Vector3 gravityValue = new Vector3(0, -12.81f, 0);

    void Start ( ) {
        Physics.gravity = gravityValue;
        this.enabled = false;
    }

}
