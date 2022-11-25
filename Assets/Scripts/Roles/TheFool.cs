using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheFool
{
    //Fields
    protected string _name;     //Name of the Unit
    protected float _baseHealth;    // Unit's Max Health
    protected float _baseEnergy;    // Unit's Max Energy
    protected float _currentHealth; // Unit's Current Health
    protected float _currentEnergy; // Unit's Current Health
    protected float _energyRecovery;    // Amount of Energy returned when refreshed

    //Properties
    public string Name //Name must not be empty, will return to last used name.
    {
        get => _name;
        set => _name = string.IsNullOrEmpty(value) ? _name : value;
    }
    public float CurrentHealth => _currentHealth;
    public int CurrentActions => (int)(_currentEnergy/10);  // Each Action Cost 10 Energy

    //Constructor
    public TheFool(string name = "The Fool", float health = 100f, float energy = 100f)
    {
        _name = name;
        _baseHealth = health;
        _baseEnergy = energy;
        _currentHealth = health;
        _currentEnergy = energy;
        _energyRecovery = 10f;
    }

    //Methods
    public string GetProperties()
    {
        var properties = $"{nameof(_name)}:{_name}, Health:{_currentHealth}/{_baseHealth}, Energy:{_currentEnergy}({CurrentActions})/{_baseEnergy}[+{_energyRecovery}/turn]";
        return properties;
    }

    public void TakeDamage(float damageTaken)
    {
        if(_currentHealth >= damageTaken)
        {
            _currentHealth = _currentHealth - damageTaken;
        } else
        {
            _currentHealth = 0;
        }
    }

    public void HealDamage(float healingDone)
    {
        if (_currentHealth < _baseHealth)
        {
            float NewHealth = _currentHealth + healingDone;
            _currentHealth = NewHealth > _baseHealth ? _baseHealth : NewHealth;
        }
    }

    public bool UseAction(int ActionsUsed)  // Returns False if Action cost greater than Energy
    {
        float energyUsed = ActionsUsed * 10;
        if(_currentEnergy >= energyUsed)
        {
            _currentEnergy -= energyUsed;
            return true;
        } else
        {
            return false;
        }
    }

    public void RefreshEnergy()
    {
        float NewEnergy = _currentEnergy + _energyRecovery;
        _currentEnergy = NewEnergy > _baseEnergy ? _baseEnergy : NewEnergy;
    }
}
