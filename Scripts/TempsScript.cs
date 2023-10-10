using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TempsScript : MonoBehaviour
{
    [SerializeField] private TMP_Text temps_text;

    private float timeElapsed;
    private int minuts, segons, centesimes;


    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        minuts = (int) (timeElapsed / 60f);
        segons = (int) (timeElapsed - minuts * 60f);
        centesimes = (int) ((timeElapsed - (int)timeElapsed) * 100f);

        temps_text.text = string.Format("Temps: {0}:{1}:{2}", minuts, segons, centesimes);
    }
}
