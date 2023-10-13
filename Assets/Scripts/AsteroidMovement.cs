using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.2f;
  
    // Update is called once per frame
    void Update()
    {
        //Get distance from asteroid to main camera
        Vector3 displacement = transform.position-Camera.main.transform.position;
        float dist = Mathf.Sqrt(Mathf.Pow(displacement.x, 2) + Mathf.Pow(displacement.y, 2) + Mathf.Pow(displacement.z, 2));

        //Get the lower bounds of the screen relative to the distance
        Vector3 screenBounds = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist));
        
        //Destroy GameObject if lower than camera y bounds
        if(transform.position.y<screenBounds.y)
        {
            Destroy(this.gameObject);
        }
        
        //Else move down
        transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
    }
}
