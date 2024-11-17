using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * I learned from here: https://www.youtube.com/watch?v=bLF1zEFVJAc&ab_channel=CodeCow
 */
public class Oscillator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Speed of the swinging motion")]
    public float speed = 1.5f;

    [SerializeField]
    [Tooltip("Maximum angle of swing")]
    public float maxAngle = 75f; 


    // Update is called once per frame
    void Update()
    {
        // Calculate the current swinging angle
        float angle = maxAngle * Mathf.Sin(Time.time * speed);

        // Rotate around the specified pivot point and axis
        transform.localRotation = Quaternion.Euler(transform.position.x, transform.position.y, angle);
    }
}