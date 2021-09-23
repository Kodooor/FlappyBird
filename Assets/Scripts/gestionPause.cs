using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Gestion de la pause
public class gestionPause : MonoBehaviour
{
  public bool pause = false;
  public AudioSource myAudioSource;
    // Start is called before the first frame update
    void Start(){
      // Au départ, le bouton pause n'est pas visible, le son est lancé
      GameObject.Find("ImagePause").GetComponent<Image>().enabled = false;
      GameObject.Find("GestionSonContinue").GetComponent<AudioSource>().Play();

    }

    // Update is called once per frame
    void Update()
    {
      // Si on appuie sur la touche P ou ECHAP
        if(Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape) ){
          // On met la variable pause à vrai
          pause = !pause;
          // Si on est en pause
          if(pause){
            // Fonction qui permet de stopper le temps dans unity
            Time.timeScale = 0;
            // On affiche l'image de pause
            GameObject.Find("ImagePause").GetComponent<Image>().enabled = true;
            // On met la musique en pause
            myAudioSource.Pause();
          }
          // Si pause = faux, on fait exactement le contraire
          else{
            Time.timeScale = 1;
            GameObject.Find("ImagePause").GetComponent<Image>().enabled = false;
            myAudioSource.UnPause();
          }
        }
    }
}
