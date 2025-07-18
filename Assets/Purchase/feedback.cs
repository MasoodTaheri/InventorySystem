using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class feedback : MonoBehaviour
{
    [SerializeField] private TMP_Text _description;
public void ShowMessage(string text)
    {
        gameObject.SetActive(true);
        _description.text = text;
    }
}
