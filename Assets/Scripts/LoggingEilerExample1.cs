using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class LoggingEilerExample1 : MonoBehaviour
{
    [SerializeField] private InputField EulerValueBound;
    [SerializeField] private Text TextResult;

    private int EulerBound;
    private int ResultValue;

    public void OnClick()
    {
        EulerBound = Convert.ToInt32(EulerValueBound.text);

        ResultValue = 0;

        for (int i = 1; i < EulerBound; i++)
        {
            if ( i % 3 == 0 || i % 5 == 0)
            {
                ResultValue = ResultValue + i;
            }
        }
        TextResult.text = "";
        TextResult.text = "Cумма всех чисел меньше " + EulerValueBound.text + " и кратных 3 и 5 равна " +  Convert.ToString(ResultValue);
        Debug.Log(TextResult.text);

    }
}

