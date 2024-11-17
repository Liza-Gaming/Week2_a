using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * I learned from here: https://www.youtube.com/watch?v=LnQudtIKfnw&ab_channel=RoyalSkies
 */
public class Rotator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("To get rotatopn around the object itself, choose positive value for z. remain x and y on 0")]
    private Vector3 _rotation;

    [SerializeField]
    [Tooltip("The speed of rotation")]
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotation * speed * Time.deltaTime);
    }
}
