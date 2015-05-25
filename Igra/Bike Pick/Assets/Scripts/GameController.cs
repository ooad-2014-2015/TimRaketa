using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
    public GameObject pu1;
    public GameObject pu2;
    public GameObject pu3;
    public GameObject pu4;
    public GameObject pu5;

    private GameObject[] niz = new GameObject[5];
    private int[,] pozicije = new int[4,4];
    int trenutna;

    public int dijelovi;
    public int bicikli;
    public float timer;

    public bool pokupio;
    public bool GameOver;

    private int indeks;

    void Start ()
    {
        niz[0] = pu1;
        niz[1] = pu2;
        niz[2] = pu3;
        niz[3] = pu2;
        niz[4] = pu3;
        for (int i = 0; i < 5; i++)
            niz[i].SetActive(false);

            pokupio = false;
        dijelovi = 0;
        bicikli = 0;
        indeks = 0;
        trenutna = 1;
        timer = 20;
        GameOver = false;

        pozicije[0, 0] = -5;
        pozicije[0, 1] = 2;
        pozicije[0, 2] = -3;
        pozicije[0, 3] = 5;
        pozicije[1, 0] = -5;
        pozicije[1, 1] = 4;
        pozicije[1, 2] = 12;
        pozicije[1, 3] = 23;
        pozicije[2, 0] = -21;
        pozicije[2, 1] = -12;
        pozicije[2, 2] = 28;
        pozicije[2, 3] = 33;
        pozicije[3, 0] = -30;
        pozicije[3, 1] = -25;
        pozicije[3, 2] = 11;
        pozicije[3, 3] = 25;

        Dobavi();
    }

    void Update()
    {
        if (!GameOver)
        {
            timer -= Time.deltaTime;

            if (timer < 0.2)
            {
                GameOver = true;
                timer = 0;
            }

            if (pokupio)
            {
                Dobavi();
                Debug.Log("Dobavio");
                pokupio = false;
            }
        }
        else
        {
        }
    }
    
    void Dobavi()
    {
        if (indeks == 5)
            indeks = 0;
        int x1 = pozicije[trenutna, 0];
        int x2 = pozicije[trenutna, 1];
        int z1 = pozicije[trenutna, 2];
        int z2 = pozicije[trenutna, 3];
        int pozX = Random.Range(x1, x2);
        int pozY = 0;
        int pozZ = Random.Range(z1, z2);
    
        niz[indeks].transform.position = new Vector3(pozX, pozY, pozZ);
        niz[indeks].SetActive(true);
        timer = 20;
        indeks++;
        int nova = 0;
        do
        {
            nova = Random.Range(0, 4);
        } while (nova == trenutna);
        trenutna = nova;
    }
}
