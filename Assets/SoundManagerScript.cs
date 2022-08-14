using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip catchh, gameover, sneeze;
    static AudioSource audioSrc;




    // Start is called before the first frame update
    void Start()
    {
        catchh = Resources.Load<AudioClip>("catch");
        gameover = Resources.Load<AudioClip>("gameover");
        sneeze = Resources.Load<AudioClip>("sneeze");

        audioSrc = GetComponent<AudioSource>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip){
        switch (clip)
        {
            case "catch":
                audioSrc.PlayOneShot(catchh);
                break;
            case "gameover":
                audioSrc.PlayOneShot(gameover);
                break;
            case "sneeze":
                audioSrc.PlayOneShot(sneeze);
                break;
        }
    }

}
