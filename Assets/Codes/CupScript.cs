using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupScript : MonoBehaviour
{
    public Animator anim;
    public Animator animAction;
    public BoxCollider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (something)
        //    animation.CrossFade("walk");
        //else
        //    animation.CrossFade("idle");
    }

    public void MouseOver()
    {
        //anim.CrossFade("Action", 5);
        anim.Play("cupAction");
    }
}
