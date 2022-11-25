using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Dollssystem : MonoBehaviour {

    public int collectiondoll;
    public List<GameObject> dolls = new List<GameObject>();
    public GameObject pickupPanel;
    public GameObject finishPanel;
    public GameObject dollCounttxt;

     void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    void Update () {
		dollCounttxt.GetComponent<Text>().text="Dolls : "+ collectiondoll+" / 9";
        if (collectiondoll>=9)
        {
            finishPanel.SetActive(true);
            this.gameObject.GetComponent<FirstPersonController>().enabled = false;
            Cursor.visible = true;
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "Doll")
        {
                pickupPanel.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.transform.tag == "Doll")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                pickupPanel.SetActive(false);
                dolls.Add(other.gameObject);
                collectiondoll++;
                other.gameObject.SetActive(false);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.transform.tag == "Doll")
        {
            pickupPanel.SetActive(false);
        }
    }
}
