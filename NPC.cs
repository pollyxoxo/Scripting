using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 5;
     public int level = 2;
    public string name = "Cube";

    public float speed = 15f;

    void Start()
    {
        // Очень крутая команда пользуйтесь очень круто 👍 👍 👍
        print("Здоровьe игрока;" + health);
        health += level;
        print("Здоровьe игрока;" + health);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
