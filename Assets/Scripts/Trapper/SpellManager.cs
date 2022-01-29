using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellManager : MonoBehaviour
{
    public KeyCode Speel_One = KeyCode.Alpha1;
    public KeyCode Speel_Two = KeyCode.Alpha2;
    public KeyCode Speel_Three = KeyCode.Alpha3;
    public KeyCode Speel_Four = KeyCode.Alpha4;

    public SpellContain _SpellContain_One;
    public SpellContain _SpellContain_Two;
    public SpellContain _SpellContain_Three;
    public SpellContain _SpellContain_Four;

    public void Start()
    {
        _SpellContain_One._SpellUsed = SystemDeck.Speel_One;
        _SpellContain_Two._SpellUsed = SystemDeck.Speel_Two;
        _SpellContain_Three._SpellUsed = SystemDeck.Speel_Three;
        _SpellContain_Four._SpellUsed = SystemDeck.Speel_Four;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(Speel_One))
        {
            _SpellContain_One.LaunchSpell();
        }   

        if(Input.GetKeyDown(Speel_Two))
        {
            _SpellContain_Two.LaunchSpell();
        }   

        if(Input.GetKeyDown(Speel_Three))
        {
            _SpellContain_Three.LaunchSpell();
        }   

        if(Input.GetKeyDown(Speel_Four))
        {
            _SpellContain_Four.LaunchSpell();
        }   
    }
}
