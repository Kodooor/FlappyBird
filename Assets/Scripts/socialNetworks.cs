using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socialNetworks : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
      // au clic sur le bouton facebook cela nous redirige vers le site de facebook
       Application.OpenURL("http://www.facebook.com/");
    }
}
