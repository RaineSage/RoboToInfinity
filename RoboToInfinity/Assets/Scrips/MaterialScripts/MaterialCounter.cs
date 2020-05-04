using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialCounter : MonoBehaviour
{
    public Text m_countText;
    public bool m_canJump = false;
    private int m_countBattery = 0;
    private int m_countGear = 0;
    private int m_countNutbolt = 0;
    private int m_countScrew = 0;



    void Start()
    {
        SetText();
    }

    private void Update()
    {
        if(m_countBattery + m_countGear + m_countNutbolt + m_countScrew == 4 )
        {
            m_canJump = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D _col)
    {
        switch (_col.gameObject.tag)
        {
            case "Battery":
                m_countBattery += 1;
                _col.gameObject.SetActive(false);
                SetText();
                break;
            case "Gear":
                m_countGear += 1;
                _col.gameObject.SetActive(false);
                SetText();
                break;
            case "Nutbolt":
                m_countNutbolt += 1;
                _col.gameObject.SetActive(false);
                SetText();
                break;
            case "Screw":
                m_countScrew += 1;
                _col.gameObject.SetActive(false);
                SetText();
                break;
            default:
                throw new System.Exception("I don't know what I collided with?!");
        }
    }

    private void SetText()
    {
        m_countText.text = $"Battery: {m_countBattery.ToString()} Gear: {m_countGear.ToString()} Nutbolt: {m_countNutbolt.ToString()} Screw: {m_countScrew.ToString()} ";
    }
}
