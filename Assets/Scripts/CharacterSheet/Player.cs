using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int health;
    private char IE;
    private char SN;
    private char TF;
    private char JP;

    public Player(int ie, int sn, int tf, int jp)
    {
        health = 100;
        if (ie >= 2)
            IE = 'E';
        else
            IE = 'I';
        if (sn >= 2)
            SN = 'S';
        else
            SN = 'N';
        if (tf >= 2)
            TF = 'F';
        else
            TF = 'T';
        if (jp >= 2)
            JP = 'J';
        else
            JP = 'P';
    }
    
    public int getHealth()
    {
        return health;
    }

    public string getMelee()
    {
        if(TF == 'T')
        {
            return "stab";
        }else if(TF == 'F')
        {
            return "slash";
        }
        return "error";
    }

    public string getRanged()
    {
        if(JP == 'J')
        {
            return "sniper";
        }else if(JP == 'P')
        {
            return "multi-shot";
        }
        return "error";
    }

    public string getDefense()
    {
        if(IE == 'I')
        {
            return "invincibility";
        }else if(IE == 'E')
        {
            return "damage absorb";
        }
        return "error";
    }

    public string getPassive()
    {
        if(SN == 'S')
        {
            return "increased windup";
        }else if(SN == 'N')
        {
            return "random dodge";
        }
        return "error";
    }
}
