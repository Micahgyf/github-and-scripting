using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;

    void Start()
    {
        health += level;
        print("NPC Health:" + health);
    }

    void Update()
    {
        // declare vector3 typed of variable(newPosition) that hold NPC position
        Vector3 newPosition = transform.position;

        // changing NPC position based on z-axis based on the NPC speed and the time between frames
        newPosition.z += speed * Time.deltaTime;

        // move NPC based on the calculated new value
        transform.position = newPosition;

    }

}
