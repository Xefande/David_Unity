
using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] float speed = 3;
    [SerializeField] Transform target;
    [SerializeField] float sinAmp = 0.1f ;
    [SerializeField] float sinFrekMultipl = 0.1f;


    // Update is called once per frame
    void Update()
    {
        //Vector3 nextPosition = Vector3.MoveTowards();


        Vector3 selfPosition = transform.position;
        Vector3 targetPosition = target.position;

        Vector3 direction = targetPosition- selfPosition;

        // direction.Normalize();

        // Sin
        /*

        float sin = Mathf.Sin(Time.time);
        sin = sinAmp * sin;
        sin = sin + 1;
        direction = direction * sin;
        */


 //       Vector3 velotity = direction * speed;
 //       transform.position = transform.position + (velotity * Time.deltaTime);

   
        transform.position = Vector3.MoveTowards(selfPosition, targetPosition, speed * Time.deltaTime);
        
        
        if(direction != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(direction);


    }
}
