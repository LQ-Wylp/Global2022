using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockageImg : MonoBehaviour
{
    public Sprite Spell1;
    public Sprite Spell2;
    public Sprite Spell3;
    public Sprite Spell4;
    public Sprite Spell5;
    public Sprite Spell6;
    public Sprite Spell7;
    public Sprite Spell8;
    public Sprite Spell9;
    public Sprite Spell10;
    public Sprite Default;

    public Sprite ReturnSpellImg(int nbSpell)
    {
        switch (nbSpell)
        {
            case 1:
                return Spell1;
                break;
            
            case 2:
                return Spell2;
                break;
            
            case 3:
                return Spell3;
                break;
                
            case 4:
                return Spell4;
                break;
                
            case 5:
                return Spell5;
                break;
                
            case 6:
                return Spell6;
                break;
                
            case 7:
                return Spell7;
                break;
                
            case 8:
                return Spell8;
                break;
                
            case 9:
                return Spell9;
                break;
                
            case 10:
                return Spell10;
                break;

            default:
                return Default;
                break;
        }
    }
}
