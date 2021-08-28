
using UnityEngine;
using UnityEngine.SceneManagement;


public class options : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
     public void Quit()
   {
    Debug.Log("quit");
     Application.Quit();
   }

}