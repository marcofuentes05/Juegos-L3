using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resume : MonoBehaviour
{
    private bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause)
            {
                resume();
            }
            else pause();
        }
    }

    public void pause()
    {
        transform.Find("pausa").gameObject.SetActive(true);
        Time.timeScale = 0.0f;
        isPause = true;
    }

    public void resume()
    {
        transform.Find("pausa").gameObject.SetActive(false);
        Time.timeScale = 1.0f;
        isPause = false;
    }

    public void cambiarEscena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}