using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickScreen : MonoBehaviour
{
  public bool menuClick = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() {
    // Dans la scène gameover, on relance une partie en appuyant sur la touche espace
      if(Input.GetKeyDown("space")){
          SceneManager.LoadScene("scene3-Game");
      }

    }

    // Fonction qui nous dirige de la scène 4 à la scène 2 via le bouton "menu"
    public void onClick(){
      SceneManager.LoadScene("scene2-Menu");
    }

}
