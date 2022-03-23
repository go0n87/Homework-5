using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class LoggingMultiplicationTable : MonoBehaviour
{

    private int[] nums = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    private string[] Results = new string[10] ;

    private string ResultStr;

    [SerializeField] private Text Str1;
    [SerializeField] private Text Str2;
    [SerializeField] private Text Str3;
    [SerializeField] private Text Str4;
    [SerializeField] private Text Str5;
    [SerializeField] private Text Str6;
    [SerializeField] private Text Str7;
    [SerializeField] private Text Str8;
    [SerializeField] private Text Str9;
    [SerializeField] private Text Str10;

    public void onClick()
    {

        Array.Clear(Results, 0, 10);

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                ResultStr  = nums[j].ToString() + @" * " + nums[i].ToString() + @" = " + Convert.ToString(nums[i] * nums[j]) + " \n";
                Results[i] = Results[i] + ResultStr;
                Debug.Log(ResultStr);
            }
        }

        Str1.text = Results[0];
        Str2.text = Results[1];
        Str3.text = Results[2];
        Str4.text = Results[3];
        Str5.text = Results[4];
        Str6.text = Results[5];
        Str7.text = Results[6];
        Str8.text = Results[7];
        Str9.text = Results[8];
        Str10.text = Results[9];

    }    
}
