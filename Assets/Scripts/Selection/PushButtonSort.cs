using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButtonSort : MonoBehaviour
{
    public ListeSort _ListeSort;
    public int _NumSort;
    public void SelectThis()
    {
        _ListeSort.addSort(_NumSort);
    }
}
