using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Definitions
    enum Screen { MainMenu, Password, Win };
    string[] level1Passwords = { "Apple", "Bananas", "Orange", "Four", "Shoes" };
    string[] level2Passwords = { "Password", "Football", "Television", "Barbeque", "Automobile" };
    string[] level3Passwords = { "Transaction", "Transfer", "Dollars", "Phonetic", "Alphabet" };


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
............HIIMHIMHMMHMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM:.............
...........MMMI:MII:MIHMHMMMMMHMMMMIMMMIMMMMMMMMMMMMMM.............
.........:MMMI:M::HM::MIHHHM:IM:MHM:IMH:IMMMIIMMMHMMMH:............
........:MMMHHM::MMI:HH:MM:I:M:MMMH:IMH:IMM::MH:MM:MM:M............
.......MMMMHMM:MMIMHMII:MM:IIIM:MHMIMMM:MMIIH::MH:HM:M............
...... :MIMMMMMMMMMHMMHMM:HHMHMMMMIMHMMMMHMHMIHIHM::MMI............
.......M:MMMMMMMMMMMMHMMMMMMMMHMMMMMMMMMMHMMMHMMIMHMMMM:...........
.......HHMMMMMMMMMMMMMMMMIMMMM.MMHMMMMHMMMMMMMMMMMIMHMMI...........
........MMMIMMMMMMMMMMIHMIMIM:.M:HMM:MIHMMMMMMMMMMMMMMMI...........
........MM.MMMMMMMMMMMH:MMMHM:.M.:MM.M.HMMMHMMMMMMMMMMMI...........
........MM.MMMMMMMMMMH::M.M.M..M..MM:M.IIMH:MMMMMMMMMMMI...........
........M:.MM:MMMMMMM:.I..:.I..H..IM:I.I.M.IMHMMMMMMMMMI...........
........M..MMMHMMMMM.:HI:HHH......H....II..:MMMMMMMHMM:...........
...........MM.MIMMMM.:H: .::I........ ...:IH:.MMMMMM:MMI...........
...........:H..MMMIM.M.:...:I.........: ..::HHHMMMMIMMMH...........
............H..IMM:I:..I:..:..........I:..:I:::MMMMMMMMM...........
...............MMH::I...I:::..........III.I::MMMHMMMMMMM...........
..............MMMHMII.. ..............:MI:I.HIIIHM:HMMMM...........
.............:MMMMIM::...........:......:H..:II:MHIMMMMM...........
.............MMMMMMMMM......................I.MMMHHMMMMM:..........
............MMMMH:MMMMM........:.:.........:MMMMMMMMMMMMI..........
...........MMMMMMHMMMMMMM.. .............:MMMMMMMMMMMMMMM..........
........ .IMMMMMMMMMMMMMMMM............:MMMMMMMMMHMMMMMMM..........
..........MMMMMMMMMMMMMMMMMI:.......:IHMMMMMMMMM::MMMMMMM..........
.........MMMMMMMIMMMMMMMMMMH:::I:I:.::HMMMMMMMMMHMMMMMMMMI.........
........HMMMMMMM:MMMMMMMMMMI:::::::..:HMMMMMMMMIMMMMMMMMMM.........
.......IMMMMM..MI:MMMMMMMMM::::..:::::.MMMMMMMMMMMMMMMMMMM ........
......:MMMM....:MMHMMMMMM:::::.....::.:.MMMMMMMHMMMMMMMMMM.........
......MMI....:::IMMMMI:.:::::.....:I::::::HMMMHIM::::::MMMH........
.....MM.....:::IMIMMM:.......:....::::::::IMMHMM:I:::I:::MM .......
....MMM.....:I:.MIHMMM........:...:::::::HMMMMI:::::....::M:.......
...:MM:........:MMMHMM..................IMMMMM::...........M.......
...MMM........:::MMMMM......:..........:HMMMMM::...................
..:MM:.......:::::MMMM........... .. .::MMM:HM::.............:.....
..MMM........:::::MMMMM:I..HHIMHMHHHM :IMMHIMH::.............I.....
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
        Terminal.WriteLine("Please enter your password:");
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
