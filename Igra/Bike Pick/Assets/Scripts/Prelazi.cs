using UnityEngine;
using System.Collections;

public class Prelazi : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void izlaz()
    {
        Application.Quit();
    }
    public void igraj()
    {
        Application.LoadLevel(1);
    }
}
