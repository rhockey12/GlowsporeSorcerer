using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Shoot : MonoBehaviour
{
    public GameObject spell;
    public Transform spawnPoint;
    public float firespeed = 0;


    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireSpell);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FireSpell(ActivateEventArgs arg)
    {
        GameObject spawnedSpell = Instantiate(spell);
        spawnedSpell.transform.position = spawnPoint.position;
        spawnedSpell.GetComponent<Rigidbody>().velocity = spawnPoint.forward * firespeed;
        Destroy(spawnedSpell, 5);
        
    }
}
