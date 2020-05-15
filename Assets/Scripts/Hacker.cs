using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Definitions
    enum Screen { MainMenu, Password, Win };

    // Game state
    int level;
    Screen currentScreen;
    string currentPassword;

    String[] passwords = { "Apple", "Password", "Transaction" };

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to HaxxOSv2.0.1");
        Terminal.WriteLine("");
        Terminal.WriteLine("Scanning for vulnerable devices...");
        Terminal.WriteLine("Devices Located!");
        Terminal.WriteLine("");
        Terminal.WriteLine("Listing Devices:");
        Terminal.WriteLine("");
        Terminal.WriteLine("1. [EASY]   Mrs_Bermont_Home_Laptop");
        Terminal.WriteLine("2. [MEDIUM] Dads-iPhone-10s-jailbroken");
        Terminal.WriteLine("3. [HARD]   Local_Bank_WiFi2-Hub");
        Terminal.WriteLine("");
        Terminal.WriteLine("Please provide the target number to initiate attack");
    }

    void OnUserInput(string input)
    { //TODO Handle differently depending on current screen
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        } else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    private void CheckPassword(string input)
    {
        if(input == currentPassword)
        {
            Terminal.WriteLine("Success! Unlocking device...");
        } else
        {
            Terminal.WriteLine("Incorrect password. Please try again.");
        }
    }

    private void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Please select a level, Mr Bond");
        }
        else if (input == "1337")
        {
            Terminal.WriteLine("Administrator Mode Activated");
        }
        else
        {
            Terminal.WriteLine("Please enter a valid option (1, 2 or 3)");
        }
    }

    void StartGame()
    {
        Terminal.WriteLine("The current selected level is " + level);
        SetPassword();
        currentScreen = Screen.Password;
    }

    private void SetPassword()
    {
        currentPassword = passwords[level-1];
    }
}
