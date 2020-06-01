using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeleteCollider : MonoBehaviour { 

    public GameObject sphere;
    public int goal;
    public TextMeshPro Title;
    public TextMeshPro Description;
    public AudioSource scrapSound;
    public AudioSource successSound;


    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider col)
    {
        Destroy(col.gameObject);
        count++;
        scrapSound.Play();


        if (count == goal)
        {
            Title.text = "COMPLETE";
            Description.text = "You may now exit the program";
            successSound.Play();
            sphere.gameObject.SetActive(true);
        }

    }
}
