﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Definitions
    enum Screen { MainMenu, Password, Win };
    string[] level1Passwords = { "apple", "bananas", "orange", "four", "shoes" };
    string[] level2Passwords = { "password", "football", "television", "barbeque", "automobile" };
    string[] level3Passwords = { "transaction", "transfer", "dollars", "phonetic", "alphabet" };


    // Game state
    int level;
    Screen currentScreen;
    string currentPassword;

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
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
        else if (currentScreen == Screen.Win)
        {
            ShowMainMenu();
        }
    }

    private void CheckPassword(string input)
    {
        if(input == currentPassword)
        {
            DisplayWinScreen();
        } else
        {
            Terminal.WriteLine("Incorrect password. Please try again.");
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
        Terminal.WriteLine("Press enter to return to the main menu.");
    }

    private void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine("Looks like she has some skeletons in her closet...");
                Terminal.WriteLine(@"
      #############                         #############
    ##            *##                     ##############*##
   #               **#                   ################**#
  #       %% %%    ***#                 ########  #  ####***#
 #       %%%%%%%   ****#               ########       ###****#
#         %%%%%    *****#             ##########     ####*****#
#   ###     %     ###***#             ####   ##### #####   ***#
#  # ####       #### #**#             ###      #######      **#
#  #     #     #     #**#             ###   X   #####   X   **#
#   #####  # #  #####***#             ####     ## # ##     ***#
#         #   #  *******#             ########## ### ##*******#
 ### #           **# ###               ### ############**# ###
     # - - - - - - #                       ##-#-#-#-#-#-##
      | | | | | | |                         | | | | | | |

                ");
                break;
            case 2:
                Terminal.WriteLine("Hmm, what's dad been watching lately?");
                Terminal.WriteLine(@"
      /~~~\
     |     |
     |     |
    __\___/__
  ,'         `,
  |  |     |  |
 |  ,'     `,  |
,'  |       |  `,
|  |         |  |
`\,'         `,/'
  |           |
  `-----------'
     |  |  |
     |  |  |
     |  |  |
     |  |  |
     |__|__|
                ");
                break;
            case 3:
                Terminal.WriteLine("Uhoh...");
                Terminal.WriteLine(@"
       .-""""-.        .-""""-.
      /        \      /        \
     /_        _\    /_        _\
    // \      / \\  // \      / \\
    |\__\    /__/|  |\__\    /__/|
     \    ||    /    \    ||    /
      \        /      \        /
       \  __  /        \  __  / 
        '.__.'          '.__.'
         |  |            |  |
         |  |            |  |          
                ");
                break;
        }
    }

    private void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            StartGame();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Please select a level, Mr Bond");
        }
        else
        {
            Terminal.WriteLine("Please enter a valid option (1, 2 or 3)");
        }
    }

    void StartGame()
    {
        SetPassword();
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("Enter your password, your hint is: " + currentPassword.Anagram());
        Terminal.WriteLine("Type \"Menu\" at any time to return to the main menu");
    }

    private void SetPassword()
    {
        switch (level)
        {
            case 1:
                currentPassword = level1Passwords[UnityEngine.Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                currentPassword = level2Passwords[UnityEngine.Random.Range(0, level2Passwords.Length)];
                break;
            case 3:
                currentPassword = level3Passwords[UnityEngine.Random.Range(0, level3Passwords.Length)];
                break;
            default:
                Debug.LogError("Invalid Level Number");
                break;
        }
    }
}
