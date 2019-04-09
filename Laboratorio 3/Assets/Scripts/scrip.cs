using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scrip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Find("contador").GetComponent<Text>().text = "Monedas recogidas: " + pelota.powerUps.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Find("contador").GetComponent<Text>().text = "Monedas recogidas: "+pelota.powerUps.ToString();
    }

    public void res(string nombre)
    {
        SceneManager.LoadScene(nombre);
        pelota.powerUps = 0;
    }
}
