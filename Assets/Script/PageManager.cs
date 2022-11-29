using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PageManager : MonoBehaviour
{
    // Start is called before the first frame update
   public void PlayGame()
   {
    //start the game
    SceneManager.LoadScene(1);
   }
}
