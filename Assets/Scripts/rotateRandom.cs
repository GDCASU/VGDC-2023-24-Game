using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //modifies range of speed
    [SerializeField] private float rotationModifier = 1.0f;
    private float rotationVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rotationVelocity = Random.Range(0.0F, rotationModifier);
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    //Rotates based on randomVelocity
    private void Rotate(){
        Vector3 rotationVector = new Vector3(Random.Range(0.0F, 1.0F),Random.Range(0.0F, 1.0F),Random.Range(0.0F, 1.0F));
        float rotateAmt = rotationVelocity * Time.deltaTime;
        transform.Rotate(rotationVector, rotateAmt);
        Debug.Log(rotateAmt);
    }
}
