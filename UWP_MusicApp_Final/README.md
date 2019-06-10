**README for UWP_MusicApp_Final**

This README is designed to give you a high level overview of the applications capabilities, as well as any remaining issues and future work.
This was also written while listening to playlists created by the application. ;-)

**Overview**
This application was created in Visual Studio 2019 with Universal Windows as the target.
The Target version is Windows 10, version 1809 (build 17763)
The Minimum version is Windows 10 Creaters Update (build 15063)

**Capabilities**
This application has the following system features enabled:
Internet (Client)
Music Library
Pictures Library

**Application Features**
Application opens to main page

**Main Page Features**
Any music contained in top directory in Music Library is displayed alphabetically by title.

To Play Music:
-User can select any of the music to play by clicking the title under the column "Play Now"
-User can click play on media player. Autoplay is set to false. 
-We have used the Media Player Element and have enabled most of its basic features. 
-The media players default image is set to an image captured on my laptop screen and is stored in assets folder in program.
-Once user has created a playlist they will be able to select that playlist in the combobox on RHS. 
-The user must click "Go" in order to navigate to the Playlist page. 

Note: We did not investigate the copyright surrounding the image, as this application is for private use only. 
Note: A nice to have for future features is for the media player to go through the music 

To Make a Playlist from MainPage:
User can select music that will be added to a playlist by clicking check box in left column. 
User than can click "Create Playlist" Button on top left to navigate to Create Playlist page.

**Create Playlist Features**
-User is able to see the list of songs selected for a playlist
-User can choose an image other than default to display on their playlist 
-User enters a name for the text file and clicks save
-save redirects user back to mainpage. Theplaylist name.txt is now shown in the playlist combo box

Restriction: Application will only accept images from top level Pictures directory on local machine.
Choosing an image other than in this location causes a file not found error. We were blocked finding a way to develop an application
That was allowed to search and pull from the entire directory structure. 
Note: If user attempts to select an image out of the top level picture directory a FileNotFoundError is thrown. 
This is handled by our system by keeping the default image in place. Future revisions will fix this bug.





