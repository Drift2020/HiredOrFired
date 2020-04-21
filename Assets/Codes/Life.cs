using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public float health;

    public Life(float baseHealth)
    {
        health = baseHealth;
    }

    public void Damaged(float damage)
    {
        health -= damage;
    }


    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
