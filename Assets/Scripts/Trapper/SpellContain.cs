using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellContain : MonoBehaviour
{
    private float _Cd;
    private float _waitForUse;
    private float _LastUse;
    public int _SpellUsed = 1;

    public TournerEcran _Spell_One;
    public SwitchPlatforme _Spell_Two;
    public CoupVent _Spell_Three;
    public HackControls _Spell_Four;
    public Acceleration _Spell_Five;
    public Pause _Spell_Six;
    public Tache _Spell_Seven;
    public NuageEclair _Spell_Eight;
    public SpawnMonster _Spell_Nine;
    public Tremblement _Spell_Ten;


    void Start()
    {
        if(_SpellUsed == 1)
        {
            _Cd = _Spell_One._Cooldown;
        }

        if(_SpellUsed == 2)
        {
            _Cd = _Spell_Two._Cooldown;
        }

        if(_SpellUsed == 3)
        {
            _Cd = _Spell_Three._Cooldown;
        }

        if(_SpellUsed == 4)
        {
            _Cd = _Spell_Four._Cooldown;
        }

        if(_SpellUsed == 5)
        {
            _Cd = _Spell_Five._Cooldown;
        }

        if(_SpellUsed == 6)
        {
            _Cd = _Spell_Six._Cooldown;
        }

        if(_SpellUsed == 7)
        {
            _Cd = _Spell_Seven._Cooldown;
        }
        if(_SpellUsed == 8)
        {
            _Cd = _Spell_Eight._Cooldown;
        }
        if(_SpellUsed == 9)
        {
            _Cd = _Spell_Nine._Cooldown;
        }
        if(_SpellUsed == 10)
        {
            _Cd = _Spell_Ten._Cooldown;
        }
    }

    void Update()
    {
        if(_waitForUse > 0)
        {
            _waitForUse -= Time.deltaTime;
            if(_waitForUse < 0)
            {
                _waitForUse = 0;
            }
        }
    }

    public void LaunchSpell()
    {
        if(_SpellUsed == 1 && _waitForUse <= 0)
        {
            _waitForUse = _Cd;
            _Spell_One.Cast();
        }

        if(_SpellUsed == 2 && _waitForUse <= 0)
        {
            _waitForUse = _Cd;
            _Spell_Two.Cast();
        }

        if(_SpellUsed == 3 && _waitForUse <= 0)
        {
            _waitForUse = _Cd;
            _Spell_Three.Cast();
        }

        if(_SpellUsed == 4 && _waitForUse <= 0)
        {
            _waitForUse = _Cd;
            _Spell_Four.Cast();
        }

        if(_SpellUsed == 5 && _waitForUse <= 0)
        {
            _waitForUse = _Cd;
            _Spell_Five.Cast();
        }

        if(_SpellUsed == 6 && _waitForUse <= 0)
        {
            _waitForUse = _Cd;
            _Spell_Six.Cast();
        }

        if(_SpellUsed == 7 && _waitForUse <= 0)
        {
            _waitForUse = _Cd;
            _Spell_Seven.Cast();
        }

        if(_SpellUsed == 8 && _waitForUse <= 0)
        {
            _waitForUse = _Cd;
            _Spell_Eight.Cast();
        }

        if(_SpellUsed == 9 && _waitForUse <= 0 && _Spell_Nine._Activated == false)
        {
            _waitForUse = _Cd;
            _Spell_Nine.Cast();
        }
        else if(_SpellUsed == 9 && _Spell_Nine._Activated == true)
        {
            _Spell_Nine.Spawn();
        }
        
        if(_SpellUsed == 10 && _waitForUse <= 0)
        {
            _waitForUse = _Cd;
            _Spell_Ten.Cast();
        }
    }
}
