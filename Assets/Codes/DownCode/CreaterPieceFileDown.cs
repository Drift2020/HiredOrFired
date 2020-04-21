using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaterPieceFileDown : MonoBehaviour
{
    public bool isWork;
    public GameObject Word;
    public GameObject File;
    public GameObject Img;
    public GameObject parant;
    public float time;
    public bool HorizontalOrVertical;
    public bool PositionLeftOrRight;

    bool Left;
    public float spead;

    public float PowerX;
    public float PowerY;


    public My_timer timer;
    int count;

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        Left = false;
      
          timer = new My_timer();
        timer.Start_timer(time, CreateObj);
      

        MoveCreator();
        count = 0;
    }
  
    // Update is called once per frame
    void Update()
    {

        if (isWork)
        {
            MoveCreator();
            timer.Update(time);
           
        }
    }
    void MoveCreator()
    {
        if (HorizontalOrVertical)
        {
            if (Left)
            {
                transform.position = new Vector3(transform.position.x - Time.deltaTime / spead, transform.position.y, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(transform.position.x + Time.deltaTime / spead, transform.position.y, transform.position.z);
            }
        }
        else
        {
            if (Left)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - Time.deltaTime / spead, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(transform.position.x , transform.position.y + Time.deltaTime / spead, transform.position.z);
            }
        }
      
    }

    [System.Obsolete]
    void CreateObj()
    {
        switch(Random.RandomRange(0,10))
        {
            case 0:
            case 2:
            case 3:
            case 6:
                if (HorizontalOrVertical)
                {
                    Instantiate(Word, gameObject.transform.position, new Quaternion(), parant.transform);
                }
                 else  if(PositionLeftOrRight)
                {
                    var i = Instantiate(Word, gameObject.transform.position, new Quaternion(), parant.transform);
                    i.GetComponent<Rigidbody2D>().AddForce(new Vector2(PowerX, PowerY), ForceMode2D.Impulse);
                }
                else
                {
                    var i = Instantiate(Word, gameObject.transform.position, new Quaternion(), parant.transform);
                    i.GetComponent<Rigidbody2D>().AddForce(new Vector2(-PowerX, PowerY), ForceMode2D.Impulse);
                }
                break;
            case 5:
            case 1:
            case 4:
            case 7:
                if (HorizontalOrVertical)
                {
                    Instantiate(File, gameObject.transform.position, new Quaternion(), parant.transform);
                }
                else if (PositionLeftOrRight)
                {
                    var i1 = Instantiate(File, gameObject.transform.position, new Quaternion(), parant.transform);
                    i1.GetComponent<Rigidbody2D>().AddForce(new Vector2(PowerX, PowerY), ForceMode2D.Impulse);
                }
                else
                {
                    var i1 = Instantiate(File, gameObject.transform.position, new Quaternion(), parant.transform);
                    i1.GetComponent<Rigidbody2D>().AddForce(new Vector2(-PowerX, PowerY), ForceMode2D.Impulse);
                }
                break;        
            case 8:
            case 9:
                if (HorizontalOrVertical)
                {
                    Instantiate(Img, gameObject.transform.position, new Quaternion(), parant.transform);
                }
                else if (PositionLeftOrRight)
                {
                    var i2 = Instantiate(Img, gameObject.transform.position, new Quaternion(), parant.transform);
                    i2.GetComponent<Rigidbody2D>().AddForce(new Vector2(PowerX, PowerY), ForceMode2D.Impulse);
                }
                else 
                {
                    var i2 = Instantiate(Img, gameObject.transform.position, new Quaternion(), parant.transform);
                    i2.GetComponent<Rigidbody2D>().AddForce(new Vector2(-PowerX, PowerY), ForceMode2D.Impulse);
                }

                break;
        } 
    }

    void OnTriggerEnter2D(Collider2D other)
    {    
        if (other.gameObject.tag.Equals("end"))
        {
            print("end");
            Left = true;
        }
        else if (other.gameObject.tag.Equals("start"))
        {
            print("start");
            Left = false;
        }
    }
}
