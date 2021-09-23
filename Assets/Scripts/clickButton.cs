using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Fonction qui nous dirige de la scène 2 à la scène 3 via le bouton "play"
    public void	onClick(){
      	SceneManager.LoadScene("Scene3-Game");
    }

    // Fonction qui nous dirige de la scène 2 à la scène de réglages via le bouton "menu"
    public void	onClickDeux(){
      	SceneManager.LoadScene("Scene2bis-Reglages");
    }
}
