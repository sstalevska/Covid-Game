using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] items;

    private BoxCollider2D col;

    float x1, x2;


    // Start is called before the first frame update
    void Awake()
    {
        col = GetComponent<BoxCollider2D> ();

        x1 = transform.position.x - col.bounds.size.x / 2f;
        x2 = transform.position.x + col.bounds.size.x / 2f;
        // the bounds of the boxcollider minus half the width to get two points left and right
    }

    void Start(){

        StartCoroutine (SpawnItems(1f));
         

    }

    IEnumerator SpawnItems(float time){
        yield return new WaitForSecondsRealtime(time);

        

        Vector3 temp = transform.position;
        temp.x = Random.Range(x1, x2);
        //randomizing the positioning of the falling items

        Instantiate (items[Random.Range(0, items.Length)], temp, Quaternion.identity);
        //randomizing the item which falls

        StartCoroutine(SpawnItems(Random.Range(1f,2f)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
