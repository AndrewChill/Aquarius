# Aquarius
![image](https://user-images.githubusercontent.com/5312834/142743056-9b9115ef-91ce-44eb-94fa-119e2eb29c11.png)

## Show Twitch Predictions in Obs Overlay

This application uses Twitch's API to retrieve prediction information for your channel and display it in a web page. This page can then be added to Obs as a Browser source, allowing you to display live prediction information in your stream.

### Setup

1. Click 'Releases' on the right side of this screen.
2. In the most recent release, expand the 'Assets' section and download the zip file.
3. Extract the zip file and run the 'Aquarius.exe' inside.
![image](https://user-images.githubusercontent.com/5312834/142743491-b1263a5b-d76d-429d-9870-029b702df1ed.png)
5. You'll need to fill in the following fields before the application will be able to retrieve prediction information:
   - **Channel Name** - This is the name of your Twitch channel, without spaces, as it appears in the URL of your channel on Twitch.
   - **Access Token** - This is an API token that has been granted permission to access prediction info.
   - **Client ID** - This is the API client that was used to generate the above token.
   - To get the Access Token and Client ID mentioned above, you can use the following instructions, though it's not technically recommended for secure production environments:
     1. Go to https://twitchtokengenerator.com/
     2. Select 'Custom Utility Token'.
     3. Scroll down to find 'channel:read:predictions' and change its value from 'No' to 'Yes'.
     4. Scroll down and click the 'Generate Token!' button.
     5. The site will have you log in through Twitch and authorize the creation of the API token.
     6. The site will then display the Access Token and Client ID.
6. After entering the values mentioned above, click the 'Save Changes' button.
7. Click on the 'Open Preview' button to open the default 'summary' panel in your default browser. It should load and display the latest prediction information from your channel.
8. Adjust the values in the 'Panel Display' group box to make the panel look how you want it. Hover over fields to get pop-up text that helps explain what they do.
9. In Obs, under 'Sources' add a 'Browser' with the following values:
   - **Local file** - True, path is the html file of the panel you'd like to display from Aquarius' Pages directory.
   - **Width** - The same value that you specified in Aquarius.
   - **Height** - The same value that you specified in Aquarius.
   - **Refresh browser when scene becomes active** - Recommended true.
![image](https://user-images.githubusercontent.com/5312834/142743868-18fe456e-930c-48a1-a423-33b511d7e3fa.png)
