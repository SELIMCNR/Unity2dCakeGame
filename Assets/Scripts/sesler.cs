using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sesler : MonoBehaviour
{
    public AudioClip gameOver;
    public AudioSource ses;

    private void Start()
    {
        ses.clip = gameOver;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision temas)
    {
        if(temas.gameObject.tag == "Player")
        {
            ses.PlayOneShot(gameOver);
            Invoke("Tekrar", 1.5f);
            Destroy(temas.gameObject);
        }
    }

    void Tekrar()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

}
