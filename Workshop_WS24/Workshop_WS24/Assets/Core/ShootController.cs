using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ShootController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnTransform;
    public float firepower = 10;
    public XRGrabInteractable grabInteractable;

    // Start is called before the first frame update
    void Start()
    {
        grabInteractable.activated.AddListener(OnTrigger);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTrigger(ActivateEventArgs arg0)
    {
        var bullet = Instantiate(bulletPrefab, spawnTransform.position, spawnTransform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * firepower, ForceMode.Impulse);
    }
}
