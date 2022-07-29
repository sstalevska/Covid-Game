using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D item){

        if(item.tag == "covid" || item.tag == "good items"){
            item.gameObject.SetActive(false);
            //for no lags
        }
    }
}
