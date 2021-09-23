using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using	UnityEngine.SceneManagement;

public class lancementJeu : MonoBehaviour
{
  public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
      // au lancement du jeu on lance la musique de lancement
        audioSource.Play();
    }

    void	Update () {
      Invoke	("goScene2",2.0f);
    }

    // après deux secondes, on va à la scène 2
    void	goScene2(){
      SceneManager.LoadScene ("Scene2-Menu");
    }
}
