using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheChariot : TheFool
{
    public TheChariot(string name = "Chariot", float health = 80f, float energy = 140f) : base(name, health, energy)
    {
        _energyRecovery = 15f;
    }
}
