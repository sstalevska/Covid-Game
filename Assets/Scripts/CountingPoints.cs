using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class CountingPoints : MonoBehaviour
{

   private Text pointsText;

    private int points = 0;

    private bool flag;


    // Start is called before the first frame update
    void Awake()
    {
        pointsText = GameObject.Find("PointsText").GetComponent<Text>();
        pointsText.text = "0";
        flag = false;
    }

    void OnTriggerEnter2D (Collider2D item){

        if(item.tag == "covid"){

            if(flag==true || points > 30){
                //survives
            SoundManagerScript.PlaySound("sneeze");

            item.gameObject.SetActive (false); 
            if(points>30){
            points-= 30;
            }else{
                points-=10;
            }
            pointsText.text = points.ToString();
            flag = false;  
            }else{
                
            //dies

            SoundManagerScript.PlaySound("gameover");

            transform.position = new Vector2(0,100); 
            

            //player off the screen
            item.gameObject.SetActive(false);
            StartCoroutine(RestartGame());
            }
        } 


          if(item.tag == "medicine"){
            SoundManagerScript.PlaySound("catch");
            item.gameObject.SetActive (false);   
            points+=3;
            pointsText.text = points.ToString();
            
          }
          if(item.tag == "vaccine"){
            flag = true;
            SoundManagerScript.PlaySound("catch");
            item.gameObject.SetActive (false);   
            points+=5;
            pointsText.text = points.ToString();
            
          }
          if(item.tag == "wash"){
            SoundManagerScript.PlaySound("catch");
            item.gameObject.SetActive (false);   
            points+= 1;
            pointsText.text = points.ToString();
            
          }
         
    }


    IEnumerator RestartGame(){
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}
