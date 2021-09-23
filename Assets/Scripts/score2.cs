using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class score2 : MonoBehaviour
{
  public Text monScore;
    // Start is called before the first frame update
    void Start() {
      // Permet d'afficher dans la scene gameover le dernier score fait par le joueur
      monScore.text = PlayerPrefs.GetInt("scoreCourant").ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

}
