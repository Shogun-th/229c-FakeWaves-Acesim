using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
   public int Respawn;
   public void Play()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

   public void Quit()
   {
      Application.Quit();
      Debug.Log("Player HAS Quit The Game");
   }
   public void Rusume()
   {
      SceneManager.LoadScene(Respawn);
   }
   public void TurnMainMenu()
   {
       
      SceneManager.LoadScene("MainMenu");
   }
      
}
