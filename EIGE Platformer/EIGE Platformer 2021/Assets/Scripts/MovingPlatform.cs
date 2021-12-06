using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
   
    public Transform[] trackingPointArray;
    
   
    
    [SerializeField] private float speed;
    private Vector3 tmpTarget;
    private int targetIndex;
    
  

    // Start is called before the first frame update
    void Start()
    {
        transform.position = trackingPointArray[0].position;
        targetIndex = 1;
        tmpTarget = trackingPointArray[targetIndex].position;
    }

    // Update is called once per frame
    void Update()
    {
        float amtToMove = speed * Time.deltaTime;
        Vector3 direction = (tmpTarget - transform.position).normalized;
        transform.Translate(direction * amtToMove);

        if(Vector3.Distance(transform.position,tmpTarget)<= 0.1f)
        {
            
            targetIndex = (++targetIndex) % trackingPointArray.Length;
            tmpTarget = trackingPointArray[targetIndex].position;
        }
    }
}
