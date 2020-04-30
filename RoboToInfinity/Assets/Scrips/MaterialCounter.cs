using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialCounter : MonoBehaviour
{
    public Text m_countText;
    private int m_count = 0;
    

    void Start()
    {
        SetText();
    }

    private void OnTriggerEnter2D(Collider2D _col)
    {
        if (_col.gameObject.tag == "Material")
        {
            _col.gameObject.SetActive(false);

            m_count += 1;
            SetText();
        }
    }

    private void SetText()
    {
        m_countText.text = "Materials: " + m_count.ToString();
    }
}
