using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class SetCulture : MonoBehaviour
{
    void Awake()
    {
        CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
    }
}
