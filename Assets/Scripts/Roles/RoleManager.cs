using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var TheFool = new TheFool();
        var Strength = new Strength();
        var Magician = new TheMagician();
        var Chariot = new TheChariot();


        Debug.Log(TheFool.GetProperties());
        Debug.Log(Strength.GetProperties());
        Debug.Log(Magician.GetProperties());
        Debug.Log(Chariot.GetProperties());

        // Health Check
        Debug.Log("Damaging and healing Strength Role");
        Strength.TakeDamage(50.5f);
        Debug.Log(Strength.GetProperties());
        Strength.HealDamage(200f);
        Debug.Log(Strength.GetProperties());

        // Energy Check
        Debug.Log("Using a 5-Cost action, and refreshing once, then thrice");
        Chariot.UseAction(5);
        Debug.Log(Chariot.GetProperties());
        Chariot.RefreshEnergy();
        Debug.Log(Chariot.GetProperties());
        Chariot.RefreshEnergy();
        Chariot.RefreshEnergy();
        Chariot.RefreshEnergy();
        Debug.Log(Chariot.GetProperties());

    }
}
