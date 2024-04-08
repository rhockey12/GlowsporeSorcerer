using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

    public class CycleSpells : MonoBehaviour
{
    [HideInInspector] public Shoot shoot;
    public InputActionReference inputActionReference;
    public GameObject[] spells;
    public int n  = 0;
    bool active = false;

    private void Awake()
    {
        shoot = GetComponent<Shoot>();
        inputActionReference.action.started += ChangeSpell;
    }

    private void OnDestroy()
    {
        inputActionReference.action.started -= ChangeSpell;
    }

    public void ChangeSpell(InputAction.CallbackContext context)
    {
        shoot.lastShootTime = 0;
        if (active)
        {
            n += 1;
        }
        
        if (n == 3 || !active)
        {
            n = 0;
            active = true;
        }
    }

    public GameObject GetSpell()
    {
        GameObject spell = spells[n];
        return spell;
    }


    public GameObject GetZapSpell()
    {
        GameObject spell = spells[0];
        return spell;
    }

    public GameObject GetFireSpell()
    {
        GameObject spell = spells[1];
        return spell;
    }

    public GameObject GetFreezeSpell()
    {
        GameObject spell = spells[2];
        return spell;
    }
}
