using System.Collections;
using System.Collections.Generic;
using Obi;
using UnityEngine;

public class ObiMixing : MonoBehaviour
{
    [SerializeField]
    private ObiSolver obiSolver;

    [SerializeField] private ObiEmitter emitter1;
    [SerializeField] private ObiEmitter emitter2;
    [SerializeField] private ObiEmitter emitter3;
    [SerializeField] private ObiEmitter emitter4;
    [SerializeField] private ObiEmitter emitter5;

    void Awake()
    {
        if (emitter1) emitter1.speed = 0f;
        if (emitter2) emitter2.speed = 0f;
        if (emitter3) emitter3.speed = 0f;
        if (emitter4) emitter4.speed = 0f;
        if (emitter5) emitter5.speed = 0f;
        
    }

    public void StartEmmitterOne()
    {
        emitter1.speed = 3f;
    }
    public void StartEmmitterTwo()
    {
        emitter2.speed = 3f;
    }
    public void StartEmmitterTree()
    {
        emitter3.speed = 3f;
    }
    public void StartEmmitterFour()
    {
        emitter4.speed = 3f;
    }
    public void StartEmmitterFive()
    {
        emitter5.speed = 3f;
    }
}
