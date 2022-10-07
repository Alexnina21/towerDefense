using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthHudController : MonoBehaviour
{
    /*private void OnEnable()
    {
        HealthBehavior.ChangeHealth += UpdateCanvas;
    }

    private void OnDisable()
    {
        HealthBehavior.ChangeHealth -= UpdateCanvas;
    }*/

    public void UpdateCanvas(int h)
    {
        GetComponent<Text>().text = "Health: " + h;
    }
}