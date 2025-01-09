using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    vie BarreDeVie = new vie();
    faim BarreDeFaim = new faim();
    soif BarreDeSoif = new soif();
    sexe BarreDeSexe = new sexe();

    void Start()
    {
        BarreDeVie.max = 100;
        BarreDeVie.valeur = 100;

        BarreDeFaim.max = 100;
        BarreDeFaim.valeur = 100;

        BarreDeSoif.max = 100;
        BarreDeSoif.valeur = 100;

        BarreDeSexe.max = 100;
        BarreDeSexe.valeur = 100;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            BarreDeVie.valeur -= 10;

        }
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            BarreDeVie.valeur += 10;

        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            BarreDeFaim.valeur -= 10;

        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            BarreDeFaim.valeur += 10;

        }

        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            BarreDeSoif.valeur -= 10;

        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            BarreDeSoif.valeur += 10;

        }


        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            BarreDeSexe.valeur -= 10;

        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            BarreDeSexe.valeur += 10;

        }
    }
}