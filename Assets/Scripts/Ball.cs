using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * I used this guide: https://www.youtube.com/watch?v=BW6QfLKkQRE&ab_channel=KapKoder
 */
public class Ball : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The maximum size that the obj can reach, choose size greater than 1")]
    public float maxSize = 2f;

    private float timer = 0f; // frame counter

    [SerializeField]
    [Tooltip("The time you want the obj to get the max size")]
    public float growTime = 2f;

    private Vector3 startScale; // The initial state of the object
    private Vector3 maxScale; // The maximum scale
    private bool isMax = false; // If the object is reaching max scale

    void Start()
    {
        startScale = transform.localScale; // Remember the start initial state
        maxScale = new Vector3(maxSize, maxSize, maxSize);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMax)
        {
            transform.localScale = Vector3.Lerp(startScale, maxScale, timer / growTime); // Grow by time
            timer += Time.deltaTime;
            if (timer > growTime) // reached the max size
            {
                isMax = true;
            }
        }
        else
        {
            transform.localScale = Vector3.Lerp(maxScale, startScale, 1 - timer / growTime); // Grow by time
            timer -= Time.deltaTime;
            if (timer <= 0) // shrank to the start size
            {
                isMax = false;
            }
        }


    }
}
