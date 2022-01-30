using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchImgSpell : MonoBehaviour
{
    public int NbChoix;
    public StockageImg _StockageImg;
    public Image _WhereSwitchImage;

    void Start()
    {
        switch (NbChoix)
        {
            case 1:
                _WhereSwitchImage.sprite = _StockageImg.ReturnSpellImg(SystemDeck.Speel_One);
                break;
            case 2:
                _WhereSwitchImage.sprite = _StockageImg.ReturnSpellImg(SystemDeck.Speel_Two);
                break;
            case 3:
                _WhereSwitchImage.sprite = _StockageImg.ReturnSpellImg(SystemDeck.Speel_Three);
                break;
            case 4:
                _WhereSwitchImage.sprite = _StockageImg.ReturnSpellImg(SystemDeck.Speel_Four);
                break;    
        }
        
    }

}
