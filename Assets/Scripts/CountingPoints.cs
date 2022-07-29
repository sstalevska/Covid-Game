using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class CountingPoints : MonoBehaviour
{

   private Text pointsText;

    private int points = 0;


    // Start is called before the first frame update
    void Awake()
    {
        pointsText = GameObject.Find("PointsText").GetComponent<Text>();
        pointsText.text = "0";
    }

    void OnTriggerEnter2D (Collider2D item){

        if(item.tag == "covid"){
            transform.position = new Vector2(0,100); 
            

            //player off the screen
            item.gameObject.SetActive(false);
            StartCoroutine(RestartGame());
        } 

        if(item.tag == "good items"){
            item.gameObject.SetActive (false);   
            points++;
            pointsText.text = points.ToString();
            
          }
    }


    IEnumerator RestartGame(){
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}
