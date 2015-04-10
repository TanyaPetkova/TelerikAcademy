﻿//Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
//Use Windows Character Map to find the Unicode code of the © symbol. 
//Note: the © symbol may be displayed incorrectly.

using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        char copyright = '\u00A9';
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("   " + copyright);
        Console.WriteLine("  " + copyright + " " + copyright);
        Console.WriteLine(" " + copyright + "   " + copyright);
        Console.WriteLine(copyright + " " + copyright + " " + copyright + " " + copyright);
    }
}       

