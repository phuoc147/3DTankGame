using UnityEngine;

public class UIDirectionControl : MonoBehaviour
{
    public bool m_UseRelativeRotation = true;
    private Quaternion m_RelativeRotation;
    void Start()
    {
        m_RelativeRotation = transform.parent.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_UseRelativeRotation)
        {
            transform.rotation = m_RelativeRotation;
        }

    }
}
