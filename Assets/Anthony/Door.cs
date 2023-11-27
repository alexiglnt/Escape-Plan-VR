using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private GameObject m_doorObject;

    private void Start()
    {
        CloseDoor();
    }

    public void OpenDoor()
    {
        Vector3 rotationDegrees = new Vector3(0f, -110f + 90f, 0f);
        m_doorObject.transform.eulerAngles = rotationDegrees;

    }

    public void CloseDoor()
    {
        Vector3 rotationDegrees = new Vector3(0f, 0f + 90f, 0f);
        m_doorObject.transform.eulerAngles = rotationDegrees;
    }
}