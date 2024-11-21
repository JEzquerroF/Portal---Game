using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowMat : MonoBehaviour
{
    public Portal m_MirrorPortal;
    public Material m_PortalMaterial;
    public Material m_BlackMaterial; 
    private MeshRenderer m_MeshRenderer; 

    void Start()
    {
        m_MeshRenderer = GetComponent<MeshRenderer>();  
        m_MeshRenderer.material = m_PortalMaterial; 
    }

    
    void Update()
    {
        if (m_MirrorPortal.m_Active)
            m_MeshRenderer.material = m_PortalMaterial;
        else
            m_MeshRenderer.material = m_BlackMaterial; 
    }
}
