using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Flip();
    }

    void Flip()
    {
        if (Keyboard.current.downArrowKey.wasPressedThisFrame) 
        {
            transform.Rotate(0,180,0);
        }
    }
}
