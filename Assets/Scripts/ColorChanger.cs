
using UnityEngine;

class ColorChanger : MonoBehaviour
{

    [SerializeField] Light light;
    [SerializeField] Color color1, color2;
    [SerializeField] float frekvency = 1;

    void Update()
    {

        float t = Mathf.Sin(Time.time * 2 * Mathf.PI * frekvency);
        t = t + 1;
        t = t / 2;

        Color c = Color.Lerp(color1, color2, t);

        light.color = c;    
    }
}
