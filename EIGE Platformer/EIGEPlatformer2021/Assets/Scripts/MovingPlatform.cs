using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform startTransform;
    [SerializeField] private Transform endTransform;
    private Vector3 startPos;
    private Vector3 endPos;
    public Transform[] tranformArray;

    public Transform nextTransform;


    // Start is called before the first frame update
    void Start()
    {
        startPos = startTransform.position;
        endPos = endTransform.position;
        transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        ////constant platform travel speed
        //float amtToMove = speed * Time.deltaTime;
        ////direction from current platform position to next travel Position (Look up vectors between points)
        //Vector3 direction = (nextTransform.position - transform.position).normalized;
        ////apply movement
        //transform.Translate(direction * speed);
        ////When platform is very close to target transform, change target of nextTransform
        //if (Vector3.Distance(transform.position, nextTransform.position) <= 0.01)
        //{
        //    //TODO: Update next target transform
        //    nextTransform= ...
        //}
        //transform.Translate(new Vector3(0, amtToMove, 0));


        float x = Time.time *speed;
        float sin = Mathf.Sin(x);
        float t = (sin / 2) + 0.5f;
        Vector3 pos = Vector3.Lerp(startPos, endPos, t);
        transform.position = pos;

        //type "for"....enter.....tab (Visual Studio)
        //for (int i = 0; i < length; i++)
        //{

        //}
    }
}
