using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gamemanager : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject levelCanvas;
   

   
   
    public void SelectlevelButton()
    {
     
        Canvas.SetActive(false);
        levelCanvas.SetActive(true);

    }

    public void Easy()
    {
        PlayerPrefs.SetInt("level", 1);
        SceneManager.LoadScene("Boxinggame");
    }

    public void Normal()
    {
        PlayerPrefs.SetInt("level", 2);
        SceneManager.LoadScene("Boxinggame");
    }

    public void Hard()
    {
        PlayerPrefs.SetInt("level", 3);
        SceneManager.LoadScene("Boxinggame");
    }

    public void Hell()
    {
        PlayerPrefs.SetInt("level", 4);
        SceneManager.LoadScene("Boxinggame");
    }

    public void Guide()
    {
        
        SceneManager.LoadScene("guidescene");
    }

    public void Back()
    {
        Canvas.SetActive(true);
        levelCanvas.SetActive(false);
    }
}
