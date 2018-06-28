## VS live Share

## Prerequisites
- Install VS Code on a first PC running Windows 10 - 1803 build 17134
- Install Visual Studio 2017 on a second PC running Windows 10 - 1803 build 17134

## Setup
1. Visualstudio live share. [Download both extensions](https://www.visualstudio.com/services/live-share/)
2. In VS code: 
    * Ensure you restart VS Code after installing the extension.
    * Tap the **Sign-in** button on the bottom toolbar.  This will show up as **Share** on subsequent launches after you have logged in.
    * Log in with your Megan login. You can find the login for each event [here](https://teams.microsoft.com/_#/xlsx/viewer/teams/https%3A~2F~2Fmicrosoft.sharepoint.com~2Fteams~2FBuildTour2018-CommunityParticipants~2FShared%20Documents~2FGeneral~2FSession%20Content~2F03%20Office%20365%20for%20Developers~2FInsider%20Dev%20Tour%20Office%20Tenants%20MVP%20Events.xlsx?threadId=19%3A08f76fe0e6774d14ba8f107340832477%40thread.skype&baseUrl=https%3A~2F~2Fmicrosoft.sharepoint.com~2Fteams~2FBuildTour2018-CommunityParticipants&fileId=725764B2-E61A-4A68-A44C-E1326D9BFB66&ctx=files&viewerAction=view) 
3. in Visual Studio, login with Adam (AdamW with same domain and login as Megan)
4. Created a **new ASP.NET Core Web Application -> Web Application** from Visual Studio, and then change the **About.cshtml.cs** to 

```cs
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            // Something is wrong here
            var output = "";
            for (int i = 0; i < 3; i++)
            {
                output += i + ' ';
            }

            Message = output;
        }
    }
}

```

5. You should have teams set up for another demo. Log in as Megan both places so you can past a connect URL into teams and take it out.
6. You should be **able to project 2 PC** at the same time on the **same screen** or you'll be forced to **switch between both PC** using a video switch. 

***Note:*** As an alternative, if both PC are recents, you can use the **Connect Application** from Windows 10. On one of the PC, go to **All Settings -> Projecting to this PC** and ensure all options are properly setup to receive a projection from another PC. Then, launch the 'Connect' Microsoft Store app. One the second PC, press the Windows + P keys and choose **"Connect to a Wireless Display"** to connect to the first PC. Snap the Connect app on the right and VS on the left. 

7. If you run into **connectivity issues** to connect between both PC, please read and check: https://docs.microsoft.com/en-us/visualstudio/liveshare/reference/connectivity that provides the rules for the **Windows Firewall**.


## Demo Script

1. From VS, open the project and show the **About.cshtml** page we'd like to debug. At this point you need to bring in co-worker to help with project (if possible do split screen for rest of demo for audience).

2. Click the **Share button** at the top right of the Visual Studio window

3. In **Microsoft Teams** from the Visual Studio PC, **paste the connection URL** into Teams.

4. From the VS Code PC, **copy the link from Teams**. From VS code, at the botton click **account and "join"**.  This will prompt you for a connect script.

5. From the VS Code PC, **paste the connection url** from Teams to VS code prompt

6. From the VS PC, **accept the collaboration session**

7. Share code and VS PC sets a breakpoint (in About.cshtml.cs), VS Code can then step through code and see stack trace

## PC Reset
	- PC1: 
		- Visual Studio open project and remove breakpoint
		- in teams delete the message
	- PC2: 
		- disconnect from project share
		- in teams delete the message