using UnityEngine;

class StepJumper : MonoBehaviour
{
    [SerializeField] Vector2 a, b;

    [SerializeField] int stepCount;
    [SerializeField] Vector2 step;


    void OnValidate()
    {
        Vector2 v = b - a;

        float length = v.magnitude;
        stepCount = Mathf.CeilToInt(length);

        step = v / stepCount;
    }
}
