using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

class Mover : MonoBehaviour
{
    [SerializeField] Vector3 velocity;
    [SerializeField] float speed;


    // Update is called once per frame
    void Update()
    {
        Vector3 diriection = GetInputDirection();
        Move(diriection);





        // Input.GetKeyDown - leütés


        // Vector3 velocity = new Vector3(1, 0, 0);
        //t.position = new Vector3(0,5,0);


        //Time.deltatime - elõzõ képfrissítés óta eltelt idõû


        



    }

    private void Move(Vector3 diriection)
    {
        velocity = diriection * speed;


        Transform t = transform;
        Vector3 pos = t.position;
        pos += velocity * Time.deltaTime;
        t.position = pos;



        if(diriection != Vector3.zero)
            t.rotation = Quaternion.LookRotation(diriection);








    }

    private static Vector3 GetInputDirection()
    {
        bool up = Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);

        float z = 0;
        if (up)
            z = z + 1;
        if (down)
            z = z - 1;

        float x = 0;
        if (left)
            x = x - 1;
        if (right)
            x = x + 1;



        Vector3 diriection = new Vector3(x, 0, z);
        diriection.Normalize();
        return diriection;
    }
}
