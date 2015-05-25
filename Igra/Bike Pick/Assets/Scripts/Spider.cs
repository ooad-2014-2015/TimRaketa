using UnityEngine;
using System.Collections;

public class Spider : MonoBehaviour {

    public GameController GC;

    void OnTriggerEnter(Collider Igrac)
    {
        GC.GameOver = true;
    }
}
