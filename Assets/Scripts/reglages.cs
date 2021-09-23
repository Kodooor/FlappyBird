using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reglages : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onClick(){
      // Retour au menu des réglages
      SceneManager.LoadScene("scene2-Menu");
    }
}
