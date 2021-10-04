using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipResear : MonoBehaviour
{
    public Research_Play researchPlay;
    public Research_Play researchPlay2;
    public Research_Play researchPlay3;



    public int cantidad;
    public float researchTime;
    float CurrentResearchTime;
    // Start is called before the first frame update
    void Start()
    {
        researchPlay = GameObject.FindWithTag("Laboratory").GetComponent<Research_Play>();
        researchPlay2 = GameObject.FindWithTag("food").GetComponent<Research_Play>();
        researchPlay3 = GameObject.FindWithTag("chemistry").GetComponent<Research_Play>();
        
    }


    //  void Update() {

    //                  CurrentResearchTime += Time.deltaTime;
    //         if (CurrentResearchTime > researchTime){
    //             researchPlay.research += cantidad;
    //             CurrentResearchTime = 0.0f;
    //         }
        
    // }

    private void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "Laboratory"){
            // Debug.Log("aaa");
            CurrentResearchTime += Time.deltaTime;
            if (CurrentResearchTime > researchTime){
                researchPlay.research += cantidad;
                CurrentResearchTime = 0.0f;
            }
        }

                if(other.tag == "food"){
            // Debug.Log("aaa");
            CurrentResearchTime += Time.deltaTime;
            if (CurrentResearchTime > researchTime){
                researchPlay2.research += cantidad;
                CurrentResearchTime = 0.0f;
            }
        }


                        if(other.tag == "chemistry"){
            // Debug.Log("aaa");
            CurrentResearchTime += Time.deltaTime;
            if (CurrentResearchTime > researchTime){
                researchPlay3.research += cantidad;
                CurrentResearchTime = 0.0f;
            }
        }
        
    }

    //      private void OnCollisionEnter2D(Collision2D other) {
        
    //     if(other.gameObject.tag == "Laboratory"){
    //         Debug.Log("toco");


    //     }
        
    // }


}
