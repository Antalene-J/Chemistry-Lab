using UnityEngine;
using System.Collections;
using System.Xml.Linq;


public class hydrogen : MonoBehaviour
{
    [SerializeField] private GameObject modalWindow; // Reference to the modal window UI

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check for left mouse button click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Cast ray from mouse position
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the collider hit is attached to an element
                if (hit.collider.CompareTag("Hydrogen"))
                {
                    modalWindow.SetActive(true);
                    Cursor.lockState = CursorLockMode.Locked;
                }                                
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            modalWindow.SetActive(false);
        }
    }   
}
