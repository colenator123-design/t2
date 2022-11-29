using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    // Start is called before the first frame update
    int LifePoint;
    int time;
    // Start is called before the first frame update
    void Start()
    {
        time=10;
        LifePoint=3;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            time-=1;
        if(time==0){
            GameObject.Find("GameManager").GetComponent<GameManager>().addbrockscore(7);
            LifePoint-=1;
            time=10;
        }
        if(LifePoint==0)
        {
            Destroy(gameObject);
        }
        }
    }
    //public void GetStone()
    //{
        //time-=1;
        //if(time==0){
            //GameObject.Find("GameManager").GetComponent<GameManager>().addbrockscore(7);
            //LifePoint-=1;
            //time=10;
        //}
        //if(LifePoint==0)
        //{
           // Destroy(gameObject);
       // }
    //}
}
