using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Text=TMPro.TextMeshProUGUI;

public class GameManager : MonoBehaviour
{
    public Text bAppleText;
    public Text bWoodText;
    public Text bRockText;
    public Text bWaterText;
    public Text hAppleText;
    public Text hWoodText;
    public Text hRockText;
    public Text hWaterText;
    int bapplescore;
    int bwoodscore;
    int brockscore;
    int bwaterscore;
    int happlescore;
    int hwoodscore;
    int hrockscore;
    int hwaterscore;
    // Start is called before the first frame update
    void Start()
    {
        bapplescore=0;
        bwoodscore=0;
        brockscore=0;
        bwaterscore=0;
        happlescore=0;
        hwoodscore=0;
        hrockscore=0;
        hwaterscore=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addbapplescore(int n)
    {
        bapplescore+=n;
        bAppleText.text=""+ bapplescore;
    }
    public void addhapplescore(int n)
    {
        happlescore+=n;
        hAppleText.text= ""+happlescore;
    }
     public void addbwoodscore(int n)
    {
        bwoodscore+=n;
        bWoodText.text= ""+bwoodscore;
    }
    public void addhwoodscore(int n)
    {
        hwoodscore+=n;
        hWoodText.text= ""+hwoodscore;
    }
    public void addbrockscore(int n)
    {
        brockscore+=n;
        bRockText.text=""+brockscore;
    }
     public void addhrockscore(int n)
    {
        hrockscore+=n;
        hRockText.text=""+hrockscore;
    }
    public void addbwaterscore(int n)
    {
        bwaterscore+=n;
        bWaterText.text=""+bwaterscore;
    }
    public void addhwaterscore(int n)
    {
        hwaterscore+=n;
        hWaterText.text=""+hwaterscore;
    }

}
