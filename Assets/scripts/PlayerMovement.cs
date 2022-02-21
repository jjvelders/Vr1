using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Define the speed at which the object moves.
        float moveSpeed = 10;
        
        //Input for forward/Backwards movement
        float ZInput = 0;

        //Input for Left/Right movement
        float Xinput = 0;

        if (Keyboard.current.wKey.IsPressed())
        {
            ZInput = 1;
        }
        if (Keyboard.current.sKey.IsPressed())
        {
            ZInput = -1;
        }
        if (Keyboard.current.dKey.IsPressed())
        {
            Xinput = 1;
        }
        if (Keyboard.current.aKey.IsPressed())
        {
            Xinput = -1;
        }
        

        //Move the object to XYZ coordinates defined as horizontalInput, 0, and verticalInput respectively.
        //transform.Translate(new Vector3(Xinput, 0, ZInput) * moveSpeed * Time.deltaTime);        
    }

    public void Move(InputAction.CallbackContext context)
    {
        Vector2 v = context.ReadValue<Vector2>();
        Debug.Log(v);
        float moveSpeed = 10;

        //Move the object to XYZ coordinates defined as horizontalInput, 0, and verticalInput respectively.
        transform.Translate(new Vector3(v.x, v.y, 0) * moveSpeed * Time.deltaTime);
    }
}
