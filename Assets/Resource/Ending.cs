using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.AI;

public class Ending : MonoBehaviour
{
    public InMemoryVariableStorage yarnInmemoryStorage; //to get value from yran

    private new AudioSource audio; 

    public NavMeshAgent cops; //choose a gameobject to be agent

    public Transform mPos; //choose a gameobject to be target

    public GameObject win;

    public GameObject lose;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();

        cops = GetComponent<NavMeshAgent>();
    }

    [YarnCommand("final")]
    // Update is called once per frame
    public void Final()
    {
        float numberFinalYarn; 
        yarnInmemoryStorage.TryGetValue("$numberFinal", out numberFinalYarn); //get value of numberFinal and set it to numberFinalYarn
        Debug.Log(numberFinalYarn);
        if(numberFinalYarn == 1) //check if player has select the right answer
        {
            audio.Play(); //play music
            cops.SetDestination(mPos.position); //cops go to catch the murderer
            win.SetActive(true);
        }
        if(numberFinalYarn == 0) //check if player has select the right answer
        {
            lose.SetActive(true);
        }

    }

}
