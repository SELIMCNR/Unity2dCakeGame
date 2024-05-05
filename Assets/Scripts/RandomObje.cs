using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomObje : MonoBehaviour
{
    public GameObject cisim;
    public Vector2 deger;
    public Text text;
    public int Puan;
    public AudioClip song;
    // Start is called before the first frame update
    void Start()
    {
        SpawnWaves();
    }
    private void Update()
    {
        text.text = "" + Puan;
    }
    void SpawnWaves()
    {
        Vector2 SpawnPosition = new Vector2(Random.Range(-deger.x,deger.x),Random.Range(deger.y,10f));
        Quaternion spawnRotate = Quaternion.identity;
        Instantiate(cisim,SpawnPosition, spawnRotate);


    }

    private void OnCollisionEnter(Collision temas)
    {
        if (temas.gameObject.tag == "Player")
        {
            Destroy(temas.gameObject);
            Puan++;
            SpawnWaves();
            AudioSource.PlayClipAtPoint(song,Camera.main.transform.position);   
        }
    }


}
