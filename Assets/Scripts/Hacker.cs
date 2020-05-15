using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var greeting = "Hello anon";
        ShowMainMenu(greeting);
    }

    private void ShowMainMenu(string greeting)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Welcome to HaxxOSv2.0.1");
        Terminal.WriteLine("");
        Terminal.WriteLine("Scanning for vulnerable devices...");
        Terminal.WriteLine("Devices Located!");
        Terminal.WriteLine("");
        Terminal.WriteLine("Listing Devices:");
        Terminal.WriteLine("");
        Terminal.WriteLine("1. [EASY]   Mrs_Bermont_Home_Laptop");
        Terminal.WriteLine("2. [MEDIUM] Dads-iPhone-10s-jailbroken");
        Terminal.WriteLine("3. [HARD]   Local_Bank_WiFi2");
        Terminal.WriteLine("");
        Terminal.WriteLine("Please provide the target number to initiate attack");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
