using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ListeSort : MonoBehaviour
{
    public int Emplacement_1 = 0;
    public int Emplacement_2 = 0;
    public int Emplacement_3 = 0;
    public int Emplacement_4 = 0;

    public void addSort(int nbSort)
    {
        if(Emplacement_1 == 0 && Emplacement_1 != nbSort)
        {
            Emplacement_1 = nbSort;
        }
        else if(Emplacement_2 == 0 && Emplacement_2 != nbSort)
        {
            Emplacement_2 = nbSort;
        }
        else if(Emplacement_3 == 0 && Emplacement_3 != nbSort)
        {
            Emplacement_3 = nbSort;
        }
        else if(Emplacement_4 == 0 && Emplacement_4 != nbSort)
        {
            Emplacement_4 = nbSort;
        }
    }

    public void pushChoix(int nbPush)
    {
        if(nbPush == 1)
        {
            Emplacement_1 = 0;
        }
        if(nbPush == 2)
        {
            Emplacement_2 = 0;
        }
        if(nbPush == 3)
        {
            Emplacement_3 = 0;
        }
        if(nbPush == 4)
        {
            Emplacement_4 = 0;
        }
    }

    public void LoadScene(string NameScene)
    {
        if(Emplacement_1 != 0 && Emplacement_2 != 0 && Emplacement_3 != 0 && Emplacement_4 != 0)
        {
            SystemDeck.Speel_One = Emplacement_1;
            SystemDeck.Speel_Two = Emplacement_2;
            SystemDeck.Speel_Three = Emplacement_3;
            SystemDeck.Speel_Four = Emplacement_4;

            SceneManager.LoadScene(NameScene);
        }
        
    }
}
