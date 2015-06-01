using UnityEngine;
using System.Collections;

public class Mouse_Input : BaseInputController {

    private Vector2 prevMousePos;
    private Vector2 mouseDelta;
    private float speedX = 0.05f;
    private float speedY = 0.1f;

    public void Start ( ) {
        prevMousePos = Input.mousePosition;
    }

    public override void CheckInput ( ) {
        // get input data from vertical and horizontal axis and 
        // store them internally in vert and horz so we don't
        // have to access them every time we need to relay input 
        // data out
        // calculate a percentage amount to use per pixel   
        float scalerX = 100f / Screen.width; 
        float scalerY = 100f / Screen.height;
        // calculate and use deltas 
        float mouseDeltaY = Input.mousePosition.y - prevMousePos.y;  
        float mouseDeltaX = Input.mousePosition.x - prevMousePos.x;
        // scale based on screen size 
        vert += ( mouseDeltaY * speedY ) * scalerY; 
        horz += ( mouseDeltaX * speedX ) * scalerX;

        // store this mouse position for the next time we’re here
        prevMousePos = Input.mousePosition;

        // set up some Boolean values for up, down, left and right      
        Left  = ( horz<0 ); 
        Right  = ( horz>0 );
        // get fire / action buttons
        Fire1= Input.GetButton( "Fire1" );
    }

    public void LateUpdate ( ) { 
        // check inputs each LateUpdate() ready for the next tick
        CheckInput( );
    }

}
