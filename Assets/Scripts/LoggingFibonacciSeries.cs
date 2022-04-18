using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class LoggingFibonacciSeries : MonoBehaviour
{
    [SerializeField] private InputField FibonacciValueBound;
    [SerializeField] private Text TextResult;

    private int FibonacciBound;
    private int CurrentValue;
    private int PreviousValue;
    private int ResultValue;

    public void OnClick()
    {
        FibonacciBound = Convert.ToInt32(FibonacciValueBound.text);

        CurrentValue = 2;
        PreviousValue = 1;
        ResultValue = 0;

        while (CurrentValue < FibonacciBound)
        {
            if (CurrentValue % 2 == 0 )
            {
                ResultValue = ResultValue + CurrentValue;
            }

            CurrentValue    =   CurrentValue + PreviousValue;
            PreviousValue   =   CurrentValue - PreviousValue;
        }

        TextResult.text = "";
        TextResult.text = "Cумма всех четных элементов ряда Фибоначчи, не превышающих " + FibonacciValueBound.text + ", равна " + Convert.ToString(ResultValue);
        Debug.Log(TextResult.text);

    }
}
