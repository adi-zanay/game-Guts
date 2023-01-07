using UnityEngine; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
 
public class MainMenu : MonoBehaviour 
{ 
  public void exitgame()
{  
        Debug.Log("exitgame");  
        Application.Quit(); 
}

public void StartGame()
{
   SceneManager.LoadScene("Game");
}
}
