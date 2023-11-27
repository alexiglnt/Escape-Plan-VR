using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RaycastLaser : MonoBehaviour
{
    public UnityEvent EventReceiverFind;
    public UnityEvent EventReceiverLose;

    [SerializeField]
    private Transform m_laserOrigin;

    private LineRenderer m_laserLine;

    private bool m_receiverFind;

    private bool ReceiverFind
    {
        get { return m_receiverFind; }
        set 
        {
            if (m_receiverFind != value) 
            {
                Debug.Log("laser : " + value);
                m_receiverFind = value;

                if (m_receiverFind)
                {
                    EventReceiverFind.Invoke();
                }
                else
                {
                    EventReceiverLose.Invoke();
                }

            }
            
        }
    }

    void Awake()
    {
        m_laserLine = GetComponent<LineRenderer>();
    }

    void Update()
    {
        m_laserLine.SetPosition(0,m_laserOrigin.position);

        RaycastHit hit;
        if(Physics.Raycast(m_laserOrigin.position, m_laserOrigin.forward, out hit))
        {
            if(hit.collider != null) 
            {
                
                m_laserLine.SetPosition(1, hit.point);

                if (hit.transform.tag == "LaserReceiver")
                {
                    ReceiverFind = true;
                }
                else
                {
                    ReceiverFind = false;
                }
            }
            else
            {
                ReceiverFind = false;
            }
        }
        else
        {
            m_laserLine.SetPosition(1, m_laserOrigin.forward * 5000);
            ReceiverFind = false;
        }
    }
}
