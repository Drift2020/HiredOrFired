using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    public bool IsCheck;
    public bool DadOrMam;
    public UpdateState myfunc;
    // Start is called before the first frame update
    public Check()
    {
        IsCheck = false;
        DadOrMam = true;
    }
    public Check(bool _IsCheck , bool _DadOrMam)
    {
        IsCheck = _IsCheck;
        DadOrMam = _DadOrMam;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
      
        if(other.gameObject.GetComponent<Check>().DadOrMam!= DadOrMam)
        {
            print("1");
            IsCheck = true;
            myfunc();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        print("0");
        
        IsCheck = false;
        
    }
}
