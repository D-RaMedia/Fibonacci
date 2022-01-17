using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Fibonacci : MonoBehaviour
{
    private long max_number = 0;

    long number1 = 0;
    long number2 = 1;
    long next_number = 0;
    
    public int AddedValue = 1;
    public int MinusValue = 1;

    public int user_input;
    public TextMeshProUGUI display_value_textholder;


    void Start()
    {
        user_input = 0;
    }
    
    // This public void generates the Fibonacci sequence, I have assigned this function to the button itself
    public void GenerateFibnacci()
    {
        max_number = user_input;

        GetFibonacci(max_number, display_value_textholder);
    }
    
    
    private void GetFibonacci(long num, TextMeshProUGUI display_value)
    {
        // The lines 41 - 50 make sure that everytime I add one value to the sequence, it also extracts the same value. That way it does not multiply
        
        GeneratePerClick();

        if (user_input > 3)
        {
            user_input -= MinusValue;
        }
        else
        {
            GeneratePerClick();
        }
            
        // Line 50 - 66 handles the Fibonacci algorithm,
        // making sure the new term becomes the old term. This way it can keep adding up
        for (int i = 1; i < num; i++)
        {
            if (i == 1)
            {
                // display_value.text += number1 + ", ";
            }
            else if (i == 2)
            {
                // display_value.text += number2 + ", ";
            }
            else
            {
                next_number = number1 + number2;
                number1 = number2;
                number2 = next_number;
                display_value.text += next_number + ", ";
            }
        }
    }

    // This small piece of codes makes sure that everytime you click the button, one bit of value keeps adding up
    void GeneratePerClick()
    {
        user_input += AddedValue;
    }
}
