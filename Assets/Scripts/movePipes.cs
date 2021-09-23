using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePipes : MonoBehaviour {

  public Vector2 movement;
  public Vector2 movementIncrease;
  public GameObject pipe1Up;
  public GameObject pipe1Down;
  private Transform pipe1UpOriginalTransform;
  private Transform pipe1DownOriginalTransform;
  public Vector2 siz;
  public Vector2 rightBottomCameraBorder;
  public Vector2 leftBottomCameraBorder;
  public bool isDead = false;

  void Start(){
    pipe1UpOriginalTransform = pipe1Up.transform;
    pipe1DownOriginalTransform = pipe1Down.transform;
    movement = new Vector2(-8,0);
    // Pour augmenter la vitesse une fois le score > 10
    movementIncrease = new Vector2(-1,0);
  }

  void	Update(){

    if(isDead == false){
      if (PlayerPrefs.GetInt("scoreCourant") < 10){
        pipe1Up.GetComponent<Rigidbody2D>().velocity	=	movement;	//	Déplacement	du	pipe	haut
        pipe1Down.GetComponent<Rigidbody2D>().velocity	=	movement;	//	Déplacement	du	pipe	bas
      }
      else{
        pipe1Up.GetComponent<Rigidbody2D>().velocity	=	movement + movementIncrease;	//	Déplacement	du	pipe	haut
        pipe1Down.GetComponent<Rigidbody2D>().velocity	=	movement + movementIncrease;	//	Déplacement	du	pipe	bas
      }
    }
      siz.x	=	pipe1Up.GetComponent<SpriteRenderer>().bounds.size.x;	//	Récupera;on	de	la	taille	d’un	pipe
      siz.y	=	pipe1Up.GetComponent<SpriteRenderer>().bounds.size.y;	//	Suffisant	car	ils ont	la	même taille
    //	Le	pipe	est sorti	de	l’écran	?	Si	oui appel	de	la	méthode moveTORightPipe
       if	(pipe1Up.transform.position.x	<	leftBottomCameraBorder.x	-	(siz.x	/	2))	{
        moveToRightPipe();
      }
  }
  void	moveToRightPipe(){
      float	randomY	=	Random.Range	(1,4)	-	2;	//	Tirage aléatoire	d’un	décalage	en	Y
      float	posX	=	rightBottomCameraBorder.x	+	(siz.x	/	2);	//	Calcul	du	X	du	bord droite	de	l’écran
      //	Calcul	du	nouvel	Y	en	reprenant	la	posi;on	Y	d’origine	du	pipe,	ici	le	downPipe1
      float	posY	=	pipe1UpOriginalTransform.position.y	+	randomY;
      //	Création	du	vector3	contenant	la	nouvelle	posi;on
      Vector3	tmpPos	=	new	Vector3	(posX,	posY,	pipe1Up.transform.position.z);
    //	Affectation	de cette	nouvelle	position	au	transform	du	gameObject
      pipe1Up.transform.position	=	tmpPos;

      //	Idem	pour	le	second	pipe
      posY	=	pipe1DownOriginalTransform.position.y	+	randomY;
      tmpPos	=	new	Vector3	(posX ,posY,	pipe1Down.transform.position.z);
      pipe1Down.transform.position	=	tmpPos;
  }


}
