using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodController : MonoBehaviour
{
    int LifePoint;
    int time;
    // Start is called before the first frame update
    void Start()
    {
        time=5;
        LifePoint=3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CutWood()
    {
        Debug.Log("touch");
        time-=1;
        if(time==0){
            GameObject.Find("GameManager").GetComponent<GameManager>().addbapplescore(3);
            GameObject.Find("GameManager").GetComponent<GameManager>().addbwoodscore(7);
            LifePoint-=1;
            time=5;
        }
        if(LifePoint==0)
        {
            Destroy(gameObject);
        }
    }
}
