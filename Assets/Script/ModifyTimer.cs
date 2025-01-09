using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyTimer : MonoBehaviour
{
    public float TimeFactor = 1;
    private void SetTimeScale(float scale)
    {
        Time.timeScale = scale;
        Time.fixedDeltaTime = scale * .02f;
    }

    private void Update()
    {
        // Si c'est la vitesse normale

        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            //Ralentissement du temps
            SetTimeScale(.5f);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Accélération du temps
            SetTimeScale(2f);

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Ultra vitesse
            SetTimeScale(TimeFactor);

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Mettre pause
            SetTimeScale(0f);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Remettre à la vitesse normale
            SetTimeScale(1f);

        }

    }
}
