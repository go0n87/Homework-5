using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class LoggingEvenNumbers : MonoBehaviour
{    
    [SerializeField] private InputField sizeArray;

    private int numberElements;    

    private int[] nums = new int[0];

    public void onClick()
    {

        if (sizeArray.text != "")
        {
            numberElements = Convert.ToInt32(sizeArray.text);

            Array.Resize(ref nums, numberElements);

            for (int i = 0; i < numberElements; i++)
            {
                nums[i] = i;
            }

            foreach (int indexValues in nums)
            {
                if (indexValues % 2 == 0)
                {
                    Debug.Log(indexValues);
                }
            }

            Array.Resize(ref nums, 0);
        }
        else 
        {
            Debug.Log("�� ����� ������ �������!");
        }
    }

}
