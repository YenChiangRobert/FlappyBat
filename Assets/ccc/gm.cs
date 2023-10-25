using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gm : MonoBehaviour
{
    public GameObject gameoverc;
    private void Start()
    {
        gameoverc.SetActive(false);
        Time.timeScale = 1;
    }
    public void gameover()
    {
        gameoverc.SetActive(true);
        Time.timeScale = 0;
    }
    public void replay()
    {
        SceneManager.LoadScene(0);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
