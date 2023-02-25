
using UnityEngine;

class Follower2 : MonoBehaviour
{
    [SerializeField] float speed = 3;
    [SerializeField] Transform target;
    [SerializeField] float sineAmp = 0.1f;
    [SerializeField] float sinefreqMultiplier = 5;

    void Update()
    {
        Vector3 selfPosition = transform.position;
        Vector3 targetPosition = target.position;

        transform.position =
            Vector3.MoveTowards(selfPosition, targetPosition, speed * Time.deltaTime);
    }
}