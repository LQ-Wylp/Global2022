using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangerSpriteSpell : MonoBehaviour
{
    public int SpellAfficher;
    public StockageImg _StockageImg;
    public Image _WhereActualise;

    void Start()
    {
        ActualiseSprint();
    }

    public void ActualiseSprint()
    {
        _WhereActualise.sprite = _StockageImg.ReturnSpellImg(SpellAfficher);
    }

    public void ChangeSprite(int nbSpell)
    {
        SpellAfficher = nbSpell;
        ActualiseSprint();
    }
}
