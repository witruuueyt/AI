using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.AI;

public class Ending : MonoBehaviour
{
    public InMemoryVariableStorage yarnInmemoryStorage;

    public GameObject cop;

    private new AudioSource audio;

    public NavMeshAgent murderer;

    public Transform copPos;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    [YarnCommand("final")]
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Final()
    {
        float numberFinalYarn;
        yarnInmemoryStorage.TryGetValue("$numberFinal", out numberFinalYarn);
        if(numberFinalYarn == 1)
        {
            audio.Play();
        }
        if(numberFinalYarn == 2)
        {
            murderer.SetDestination(copPos.position);
        }

    }

}
