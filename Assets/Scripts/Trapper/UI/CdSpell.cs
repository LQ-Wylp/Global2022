using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CdSpell : MonoBehaviour
{
    public Image ImgCd;

    public void RefreshVisuel(float cbInitial, float cdRestant)
    {
        ImgCd.fillAmount = cdRestant / cbInitial;
    }
}
