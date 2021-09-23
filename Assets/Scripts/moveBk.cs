using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBk : MonoBehaviour{

  public float positionRestartX;
  public Vector2 siz;
  public Vector2 leftBottomCameraBorder;
  public Vector2 movement;
    // Start is called before the first frame update
    void Start(){
    
    }

//   This is the Update	method of the	moveBk script.
//   The positionRestartX variable is public.
//   It is set with the	transform.position.x background3 value.
    // Update is called once per frame
    void Update() {

      GetComponent<Rigidbody2D>().velocity = movement;

      siz.x	=	gameObject.GetComponent<SpriteRenderer>	().bounds.size.x;
      siz.y	=	gameObject.GetComponent<SpriteRenderer>	().bounds.size.y;

      //	If the backgound exits the screen
      //	Set	the	X	positon	with the original	backGround3	X	position
      if	(transform.position.x	<	leftBottomCameraBorder.x	-	(siz.x	/	2))	{
        transform.position = new	Vector3(positionRestartX,transform.position.y,transform.position.z);
      }

    }

}
