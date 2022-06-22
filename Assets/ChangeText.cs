using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    TextMeshProUGUI target;
    // Start is called before the first frame update
    void Start()
    {
        target = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void SetText(string t)
    {
        target.text = t;
    }
}
