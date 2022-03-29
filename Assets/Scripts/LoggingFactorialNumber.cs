using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class LoggingFactorialNumber : MonoBehaviour
{
    [SerializeField] private InputField FactorialNumberInput;
    [SerializeField] private Text TextResult;

    private int FactorialNumber;
    private int FactorialCalculation;    

    public void OutputFactorial()
    {
        FactorialCalculation    = 1;
        TextResult.text         = "";
        FactorialNumber         = Convert.ToInt32(FactorialNumberInput.text);

        for (int i = 1; i<= FactorialNumber; i++) 
        {
            FactorialCalculation = FactorialCalculation * i;
            if (i == FactorialNumber)
            {
                TextResult.text = TextResult.text + @" * " + Convert.ToString(i);
                TextResult.text = TextResult.text + @" = " + Convert.ToString(FactorialCalculation);
            }
            else if (TextResult.text == "")
            {
                TextResult.text = Convert.ToString(i);
            }
            else 
            {
                TextResult.text = TextResult.text + @" * " + Convert.ToString(i);
            }
        }
        Debug.Log(TextResult.text);
    }

}
