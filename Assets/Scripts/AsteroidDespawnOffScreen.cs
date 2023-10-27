using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Gets displacement from asteroid pos to camera pos
        Vector3 displacement = transform.position - Camera.main.transform.position;

        //Varies bounds based on its z distance from camera
        float screenBoundsL = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, displacement.z)).x;
        float screenBoundsR = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, displacement.z)).x;
        float screenBoundsB = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, displacement.z)).y;

        //Destroy GameObject if lower than camera y bounds
        if (transform.position.y<screenBoundsB||transform.position.x<screenBoundsL||transform.position.x>screenBoundsR)
        {
            Destroy(this.gameObject);
        }
    }
}
