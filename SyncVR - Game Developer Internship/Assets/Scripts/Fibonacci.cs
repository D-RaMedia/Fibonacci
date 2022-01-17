using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Fibonacci : MonoBehaviour
{
    private long max_number = 0;

    long term1 = 0;
    long term2 = 1;
    long next_term = 0;
    
    public int FibonacciPerClick = 1;
    public int FibanacciTotal = 1;

    public int user_input;
    public TextMeshProUGUI display_value_textholder;


    void Start()
    {
        user_input = 0;
    }

    public void GenerateFibnacci()
    {
        max_number = user_input;

        GetFibonacci(max_number, display_value_textholder);
    }

    private void GetFibonacci(long num, TextMeshProUGUI display_value)
    {
        GeneratePerClick();

        if (user_input > 3)
        {
            user_input -= FibanacciTotal;
        }
        else
        {
            GeneratePerClick();
        }
            
        for (int i = 1; i < num; i++)
        {
            if (i == 1)
            {
                // display_value.text += term1 + ", ";
            }
            else if (i == 2)
            {
                // display_value.text += term2 + ", ";
            }
            else
            {
                next_term = term1 + term2;
                term1 = term2;
                term2 = next_term;
                display_value.text += next_term + ", ";
            }
        }
    }

    void GeneratePerClick()
    {
        user_input += FibonacciPerClick;
    }
}
