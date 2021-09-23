using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collideManagementBird : MonoBehaviour{

  public GameObject bird;
  public movePipes movePipesUn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    //    bird.transform.Rotate(Vector3.forward * Time.deltaTime * 1000);

    }

    // Fonction qui se déclenche lorsque l'oiseau rentre en collision avec un tuyau ou dépasse le haut ou le bas de l'écran
    void OnCollisionEnter2D()
    {
      Debug.Log("Collision");
      SceneManager.LoadScene("scene4-GameOver");
    }
}
