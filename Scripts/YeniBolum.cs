using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class YeniBolum : MonoBehaviour
{
    public void YeniBolumAc()
    {
        if (SceneManager.GetActiveScene().buildIndex == 15)
        {        
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex));          
        }
        else
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) + 1);      
    }
    public void YeniBolumAcLevel2()
    {    
        SceneManager.LoadScene(6);     
    }
    public void YeniBolumAcLevel3()
    {
        SceneManager.LoadScene(11);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}