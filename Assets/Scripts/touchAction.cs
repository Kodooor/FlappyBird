using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchAction : MonoBehaviour
{
  public float flyvelocity = 200f;
  private Rigidbody2D body;
  public AudioSource audioSource;
  public SpriteRenderer bird;
  public Animator animator;
  public Sprite newSpriteUn;
  // public Sprite newSpriteDeux;
  // Start is called before the first frame update
  void Start()
  {
      body = GetComponent<Rigidbody2D>();
      bird = GetComponent<SpriteRenderer>();
      animator = GetComponent<Animator>();
  }

  // Update is called once per frame
  void Update()
  {
      // Dans le jeu, cette condition permet de faire sauter l'oiseau
      if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")){
          body.velocity = Vector2.zero;
          body.AddForce(new Vector2(0, flyvelocity));
          audioSource.Play();
      }

      // Si on fait un clic droit, ces conditions permette de switcher d'oiseau et d'animation en jeu
      // Comme visible dans les réglages
      if (Input.GetMouseButtonDown(1)){

        if(animator.GetCurrentAnimatorStateInfo(0).IsName("birdFlying")){
          animator.SetTrigger("triggerBirdFlyingDeux");
        }
        else{
          animator.SetTrigger("triggerBirdFlying");
        }
      
      }

    }
}
