using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour 
{
    public GameController GC;
    private Vector3 uvis;

    void Start()
    {
        uvis = new Vector3(0, 30, 0);
    }

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider Igrac)
    {
        if (GC.GameOver == false)
        {
            GC.dijelovi += 1;
            Debug.Log("Dotako");
            GC.pokupio = true;
            if (GC.dijelovi == 5)
            {
                GC.dijelovi = 0;
                GC.bicikli += 1;
            }
            gameObject.SetActive(false);
            transform.position += uvis;
        }
    }
}
