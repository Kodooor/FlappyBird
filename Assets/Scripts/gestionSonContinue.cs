using UnityEngine;
using System.Collections;
public class gestionSonContinue : MonoBehaviour {

public static gestionSonContinue Instance;
// Use this for initialization
    void Start () {

    }

// Update is called once per frame
void Update () {

}

void Awake()
{

    if (Instance)
        DestroyImmediate (gameObject);
    else {
      // On utilise cette fonction pour que la gameobject qui contient la musique du jeu ne se détruise pas lorsqu'on change
      // de vue : on a ainsi la musique qui continue en passant à la scène gameover
        DontDestroyOnLoad (gameObject);
        Instance = this;

    }
  }
}
