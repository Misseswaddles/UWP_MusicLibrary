**README for UWP_MusicApp_Final**

This README is designed to give you a high level overview of the applications capabilities, as well as any remaining issues and future work.
This was also written while listening to playlists created by the application. ;-)

**Overview**
This Universal Windows application was created in C# using Visual Studio 2019 with Universal Windows as the target.
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
1. User can select any of the music to play by clicking the title under the column "Play Now"
2. User can click play on media player. Autoplay is set to false. 
3. We have used the Media Player Element and have enabled most of its basic features. 
4. The media players default image is set to an image captured on my laptop screen and is stored in assets folder in program.
5. Once user has created a playlist they will be able to select that playlist in the combobox on RHS. 
6. The user must click "Go" in order to navigate to the Playlist page. 

Note: We did not investigate the copyright surrounding the image, as this application is for private use only. 
Note: A nice to have for future features is for the media player to go through the music 

To Make a Playlist from MainPage:
1. User can select music that will be added to a playlist by clicking check box in left column. 
2. User then can click "Create Playlist" Button on top left to navigate to Create Playlist page.

**Create Playlist Features**
1. User is able to see the list of songs selected for a playlist from main page
2. User can choose an image other than default to set as coverimage for their mediaplayer on playlist page
3. User enters a name for the text file and clicks save
4. Save redirects user back to mainpage. Theplaylist "PlayListname.txt" is now shown in the playlist combo box

Restriction: Application will only accept images from top level Pictures directory on local machine.
Choosing an image other than in this location causes a file not found error. We were blocked finding a way to develop an application
That was allowed to search and pull from the entire directory structure. 
Note: If user attempts to select an image out of the top level picture directory a FileNotFoundError is thrown. 
This is handled by our system by keeping the default image in place. Future revisions will fix this bug.

**PlayPlaylist Features**
1. User is able to see the list of songs for the playlist
2. User has similar playlist functionality as on the main page--play by clicking "play now"
3. User can delete songs by selecting check box on left hand side and clicking delete button. (**see note below**)
4. User can navigate back to the main page.

Note: Although the user is able to delete the songs on the UI, the songs are not actually deleted from the playlist text file. This means that once the playlist reloads the "deleted songs" will reappear. I wasn't able to get to completing this feature. The fix would be to store the songs selected for deletion, then re-write the playlist file omitting the songs selected for deletion. 

**Room for growth:**
1. Refactoring code redundancy. 
2. Improving commenting structure. 
3. Improving UI


