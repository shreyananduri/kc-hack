using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ItemCollector : MonoBehaviour
{
    private int oints = 0;
    private int waters = 0;
    private int diapers = 0;

    [SerializeField] private TMP_Text ointsText;
    [SerializeField] private TMP_Text watersText;
    [SerializeField] private TMP_Text diapersText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ointment"))
        {
            Destroy(collision.gameObject);
            oints++;
            ointsText.text = "Meds: " + oints;
        }

        if (collision.gameObject.CompareTag("water"))
        {
            Destroy(collision.gameObject);
            waters++;
            watersText.text = "Water: " + waters;
        }

        if (collision.gameObject.CompareTag("diaper"))
        {
            Destroy(collision.gameObject);
            diapers++;
            diapersText.text = "Diapers: " + diapers;
        }
    }
}
