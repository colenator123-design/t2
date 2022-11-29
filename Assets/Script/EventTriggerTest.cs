using UnityEngine;
using UnityEngine.EventSystems;
 
public class EventTriggerTest : MonoBehaviour
{
    int LifePoint;
    int time;

 void Start()
    {
        time=5;
        LifePoint=3;
    }
    private void Update() {
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("click");
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
}