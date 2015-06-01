using UnityEngine;
using System.Collections;

public class AutomaticDestroyObject : MonoBehaviour {

    public float timeBeforeObjectDestroys;

    void Start ( ) {
        // the function destroyGO() will be called in 
        // timeBeforeObjectDestroys seconds
        Invoke("DestroyGO", timeBeforeObjectDestroys);
    }

    void DestroyGO ( ) { 
        // destroy this gameObject
        Destroy(gameObject);
    }

}
