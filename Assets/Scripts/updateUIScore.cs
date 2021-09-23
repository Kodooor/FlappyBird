using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Classe qui gère le meilleur score
public class updateUIScore : MonoBehaviour
{
  public Text textScore;
  public Text textMeilleurScore;
    // Start is called before the first frame update
    void Start()
    {
      // On affiche le meilleur score
      textMeilleurScore.text = "Meilleur score " + PlayerPrefs.GetInt("meilleurScore");
      textScore.text = "0";
      PlayerPrefs.SetInt("scoreCourant", 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    // On change le meilleur score si le score courant est mieux
    public void updateScore(int score){
      textScore.text = score.ToString();
      if(score > PlayerPrefs.GetInt("meilleurScore")){
        PlayerPrefs.SetInt("meilleurScore", score);
      }
      PlayerPrefs.SetInt("scoreCourant", score);
    }
}
