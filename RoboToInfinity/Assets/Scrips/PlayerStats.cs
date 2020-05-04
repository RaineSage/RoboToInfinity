using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Stats", menuName = "Player", order = 0)]
public class PlayerStats : ScriptableObject
{
    [SerializeField]
    private float maxHealthPoints = 100;

    [SerializeField]
    private float healthPoints;
    

    public float HP
    {
        get
        {
            if (isAlive) return healthPoints;
            if (!isAlive) return 0;
            throw new System.Exception("The Robot is not Alive but it is also Alive??");
        }
        set
        {
            healthPoints += value;
            if (healthPoints <= 0)
            {
                isAlive = false;
                healthPoints = 0;
            }
            if (healthPoints > maxHealthPoints)
            {
                healthPoints = maxHealthPoints;
            }
        }
    }

    [SerializeField]
    private float maxEnergyPoints = 100;

    [SerializeField]
    private float energyPoints;

    public float Energy
    {
        get
        {
            if (haveEnergy) return energyPoints;
            if (!haveEnergy) return 0;
            throw new System.Exception("The Robot have Energy but also have no Energy??");
        }
        set
        {
            energyPoints += value;
            if (energyPoints == 0)
            {
                haveEnergy = false;
                energyPoints = 0;
            }
            else if (energyPoints < 0)
            {
                Debug.Log("The Robtoter dont have enough Energy. Please check with 'HasEnoughEnergy(int)' before you try to set the Energy. Thx ^^");
            }
        }
    }

    public bool isAlive = true;

    public bool haveEnergy = true;

    public int CurrLevel;


    public bool HasEnoughEnergy(float _input)
    {
        if (Energy - _input < 0) return false;
        return true;
    }

    [SerializeField]
    private float RegenerateHPTimer = 0.2f;

    public bool regHP = true;

    public IEnumerator addHealth(float _speed)
    {
        while (regHP)
        {
            if (HP < maxHealthPoints)
            {
                yield return new WaitForSeconds(RegenerateHPTimer);
                HP = +(1 * _speed);
            }
            else
            {
                yield return null;
            }
        }
    }

    [SerializeField]
    private float RegenerateEnergyTimer = 0.2f;

    public bool regEnergy = true;

    public IEnumerator addEnergy(float _speed)
    {
        while (regEnergy)
        {
            if (Energy < maxEnergyPoints)
            {
                yield return new WaitForSeconds(RegenerateEnergyTimer);
                Energy = +(1 * _speed);
            }
            else
            {
                yield return null;
            }
        }
    }
}
