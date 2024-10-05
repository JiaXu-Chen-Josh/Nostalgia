using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShift : MonoBehaviour
{
    [Tooltip("Stores the final position of the camera.")]
    [SerializeField] float finalPos;
    Vector2 initialPos;
    [Tooltip("Modifies the speed of the movement, must be above 0 to function.")]
    [SerializeField] float speed;
    Vector2 differenceVect;


    private void Start()
    {
        initialPos = transform.position;
    }
    /// <summary>
    /// Moves camera up to the thought bubbles. Once transform.y reaches finalPos, stops. 
    /// </summary>
    /// <returns>current y value</returns> 
    public float Thinking()
    {
        transform.position += new Vector3(0, (finalPos * (Time.deltaTime)) * speed, 0);
        if (this.transform.position.y > finalPos)
            {
                transform.position = new Vector3(0, finalPos, 0);
                return transform.position.y;
            }
        return transform.position.y;
    }

    /// <summary>
    /// Moves camera down to the main screen. Once transform.y reaches initial position, stops.
    /// </summary>
    /// <returns>current y value</returns>
    public float Down()
    {
         transform.position += new Vector3(0, (finalPos * (Time.deltaTime)) * -speed, 0);
        if (this.transform.position.y < initialPos.y)
        {
            transform.position = new Vector3(0, initialPos.y, 0);
            return transform.position.y;
        }
        return transform.position.y;
    }

}
