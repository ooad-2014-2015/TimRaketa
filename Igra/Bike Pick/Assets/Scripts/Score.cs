using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class Score : MonoBehaviour {

    public GameController GC;
    public Text bicikli;
    public Text dijelovi;
    public Text timer;
    public Text GameOver;
    public float vrijeme;
    float vr;

    void Start()
    {
        vr = 5;
    }
	
	void Update () 
    {
        vrijeme = Mathf.Round(GC.timer);
        dijelovi.text = "Dijelovi: " + GC.dijelovi.ToString();
        bicikli.text = "Bicikli: " + GC.bicikli.ToString();
        timer.text = "Timer: " + vrijeme.ToString() + " s";
        if (GC.GameOver)
        {
            vr -= Time.deltaTime;
            GameOver.text = "      GAME OVER!\n Sakupljeno bicikala: " + GC.bicikli.ToString();
        }
        if (vr <= 1)
            Application.LoadLevel(0);
	}
}
