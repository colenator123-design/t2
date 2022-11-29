using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour
{
    int time;
    // Start is called before the first frame update
    void Start()
    {
        time=5;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            time-=1;
        if(time==0){
            GameObject.Find("GameManager").GetComponent<GameManager>().addbwaterscore(7);
            time=5;
        }
        }
    }
    //public void OnTriggerEnter2D(Collider2D other)
   // {
        //if(other.gameObject.tag=="box")
        //{
            //Destroy(gameObject);
            //waterpower=10;
       // }
    //}
    //public void GetWater()
    //{
        //time-=1;
        //if(time==0){
           // GameObject.Find("GameManager").GetComponent<GameManager>().addbwaterscore(7);
           // time=5;
       // }
        
    //}
}
