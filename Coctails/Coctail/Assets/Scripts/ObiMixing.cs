using System.Collections;
using System.Collections.Generic;
using Obi;
using TMPro;
using UnityEngine;

public class ObiMixing : MonoBehaviour
{
    [SerializeField]
    private ObiSolver obiSolver;

    [SerializeField] private ObiFluidRenderer renderer;
    [SerializeField] private ObiEmitter emitter1;
    [SerializeField] private ObiEmitter emitter2;
    [SerializeField] private ObiEmitter emitter3;
    [SerializeField] private ObiEmitter emitter4;
    [SerializeField] private ObiEmitter emitter5;

    [SerializeField] private TextMeshProUGUI text;
    void Awake()
    {
        if (emitter1) emitter1.speed = 0f;
        if (emitter2) emitter2.speed = 0f;
        if (emitter3) emitter3.speed = 0f;
        if (emitter4) emitter4.speed = 0f;
        if (emitter5) emitter5.speed = 0f;
        if (renderer == null)
        {
            renderer = FindObjectOfType<ObiFluidRenderer>();
        }
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

    public void TurnSurface()
    {
        renderer.settings.generateSurface = !renderer.settings.generateSurface;
        text.text = "Surface Reconstruction : " + renderer.settings.generateSurface;
    }
    public void TurnLighting()
    {
        renderer.settings.lighting = !renderer.settings.lighting;
        text.text = "Lighting : " + renderer.settings.lighting;
    }
    public void TurnReflection()
    {
        renderer.settings.generateReflection = !renderer.settings.generateReflection;
        text.text = "Reflection : " + renderer.settings.generateReflection;
    }
    public void TurnRefraction()
    {
        renderer.settings.generateRefraction = !renderer.settings.generateRefraction;
        text.text = "Refraction : " + renderer.settings.generateRefraction;
    }
    public void TurnFoam()
    {
        renderer.settings.generateFoam = !renderer.settings.generateFoam;
        text.text = "Foam : " + renderer.settings.generateFoam;
    }
}
