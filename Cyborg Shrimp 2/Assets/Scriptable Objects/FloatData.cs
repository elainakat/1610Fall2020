using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float fillValue;

    public void UpdateValue(float number)
    {
        fillValue += number;
    }

    public void DisplayValue(Image img)
    {
        img.fillAmount = fillValue;
    }
}
