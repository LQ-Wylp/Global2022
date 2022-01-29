using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushChoix : MonoBehaviour
{
    public ListeSort _ListeSort;
    public int _NbChoix;
    public void PushButton()
    {
        _ListeSort.pushChoix(_NbChoix);
    }
}
