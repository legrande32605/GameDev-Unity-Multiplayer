# Make Online Games Using Unity's NEW Multiplayer Framework

![Maintained by LeGrande32605](https://img.shields.io/static/v1?label=Maintained%20by&message=LeGrande32605&color=blue)
![Status](https://img.shields.io/static/v1?label=Status&message=Work%20In%20Progress&color=yellow)
![Repo Size](https://img.shields.io/github/repo-size/legrande32605/GameDev-Unity-Multiplayer)

-----

### Game Image
![Tanks](./Assets/Images/SplashImage.png)
<sub><sub>Artist: Grant Abbitt</sub></sub>

## Design Notes
This project creates a 2D multiplayer tank game using Untity's 2D (URP) game template.  It will be using Unity's gaming services to incorporate multiplayer connection, matchmaking, and teams.

Graphic in this game are provided by [GameDev.TV](https://gamedev.tv) and designed by [Grant Abbitt](https://uk.linkedin.com/in/grant-abbitt?original_referer=https%3A%2F%2Fwww.google.com%2F).


## Results of Course Videos

### Section 1 - Introduction & Setup
- Part 1: Welcome To The Course 

    > Summary: Description of what will be covered in the course
    > - Make Online Unity Course from Scratch
    > - Core Game Play - Player Movement and Environment Interaction
    > - Unity Gaming Services - Multiplayer, Authentication, and Lobbies 
    > - Advanced Game Play - Leaderboard, Respawning, Radar, Bounties, and Healing Pads
    > - Advance Unity Gaming Services - Dedicated Hosting Server, Match Making, and Teams
<p> </p>

- Part 2: Set Up Unity & VS Code  

    > Summary: Install and Configure Software to Develop Game
    > - Unity Hub
    > - Unity Editor 2022.2.6f1 is the stable version used in course
    > - Visual Studio w/Extensions
    >   - Microsoft C#
    >   - Unity Code Snipets
    > - Set Unity to use VS Code as Editor
<p> </p>

- Part 3: Networking Basics 

    > Summary: Basics of Unity Netcode
    > - (netcode documentation)[docs-multiplayer.unity3d.com/netcode/current/about]
    >   - Multiplayer Networking Terminology
    >   - Lag Conceptual Knowledge
    >   - Configuration
    >   - Listen Server and Host architecture
    > - Client-Server Model (Self-Hosted)
    > - Client-Server Model (Dedicated)
<p> </p> 

- Part 4: Installation & Setup 
 
    > Summary: Setup Unity and Testing Sample
    > - Install Unity Editor 2022.2.6f1
    > - Create Project
    > - Add Networking Packages
    >   - NetCode for GameObjects
    >   - Multiplayer
    >   - MatchMaker
    >   - Cinemachine
    >   - Input System
    > - Create Sample Project
    >   - Add Network Manager
    >       - Handles Player Connecting
    >       - Handles Server Setup
    >       - Handles Connection Approval
    >       - Handles Transpor (data transmission)
    >       - Network Prefabs
    >   - Add Unity Transport (in Network Manager)
    >   - Add Player (Test Object)
    >       - Sprite
    >       - Network Object (Used to assign object to a player session)
    >   - Add Button (Join Session)
    >       - Join C# Script
    >       - Link Script Callback
<p> </p> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Installation & Setup](./Assets/Images/Thumb%20-%20Section1-Lesson4.png)](./Assets/Images/Section1-Lesson4.png)

- Part 5: Community & Support 
 
    > Summary: Lists options for community support
<p> </p> 

- Part 6: Accessing Our Projects 
 
    > Summary: GameDev.TV's GitHub Repositories
    > - https://github.com/GameDevTV
    > - https://gitlab.com/GameDevTV/unity-multiplayer/unity-multiplayer
<p> </p> 

### Section 2 - Core Gameplay

- Part 1: Section Intro - Core Gameplay 
 
    > Summary: Nathan introduces you to the section of the course where you’ll be creating the Core Gameplay features.
<p> </p> 

- Part 2: Importing Assets 
 
    > Summary: Importing Assets for game and creating player PreFab
    > - Importing Assets
    >   - Download TankAssets.zip
    >   - Copy TankAssets.unitypackage out of zip file
    >   - Drag and drop into project
    >   - Import into Art folder
    > - Create Player Prefab
    >   - Remove Previous Sprite Component
    >   - Restrict Network Transform to X and Y position only
    >       - Tank Treads
    >           - Add child object for Treads
    >           - Add Tread sprite
    >           - Add Network Transform 
    >           - Restrict Network Transform to Z rotation only
    >           - Add Box Colider
    >       - Tank Body (child of Treads)
    >           - Add Sprite Render
    >           - Add Turret sprite
    >       - Turret Pivot (what the turret pivots around)
    >           - Add child object for TurretPivot
    >           - Add Network Transform
    >           - Restrict Network Transform to Z rotation only
    >       - Turret (child of Turret Pivot)
    >           - Add Sprite Render
    >           - Add Turret sprite
    >           - Line up Turret so it spins properly on the body
    >       - Machine Gun Pivot (Child of Turret)
    >           - Expansion beyond scope of course
    >           - Add Network Transform
    >           - Restrict Network Transfor to Z rotation only
    >       - Machine Gun (child of Machine Gun Pivot)
    >           - Expansion beyond scope of course
    >           - Add Sprite Render
    >           - Add Machine Gun Sprite
    >           - Line up so it spins around properly
    >   - Graphics Sorting
    >       - Add new sorting layer (player)
    >       - Set Player Sprites to the Player sorting Layer
    >       - Set Sprite order on all sprites to make tank properly
<p> </p> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Importing Assets](./Assets/Images/Thumb%20-%20Section2-Lesson2.png)](./Assets/Images/Section2-Lesson2.png)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Importing Assets](./Assets/Images/Thumb%20-%20Section2-Lesson2a.png)](./Assets/Images/Section2-Lesson2a.png)

- Part 3: Reading Input 
 
    > Summary: Lorem ipsum dolor sit amet
    > - consectetur adipiscing elit
    > - sed do eiusmod tempor incididunt ut labore et dolore magna aliqua
<p> </p> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Reading Input](./Assets/Images/Thumb%20-%20future.png)](./Assets/Images/future.png)

- Part 4: Network Authority 
 
    > Summary: Lorem ipsum dolor sit amet
    > - consectetur adipiscing elit
    > - sed do eiusmod tempor incididunt ut labore et dolore magna aliqua
<p> </p> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Network Authority](./Assets/Images/Thumb%20-%20future.png)](./Assets/Images/future.png)

- Part 5: Player Movement 
 
    > Summary: Lorem ipsum dolor sit amet
    > - consectetur adipiscing elit
    > - sed do eiusmod tempor incididunt ut labore et dolore magna aliqua
<p> </p> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Player Movement](./Assets/Images/Thumb%20-%20future.png)](./Assets/Images/future.png)

- Part 6: Player Aiming 
 
    > Summary: Lorem ipsum dolor sit amet
    > - consectetur adipiscing elit
    > - sed do eiusmod tempor incididunt ut labore et dolore magna aliqua
<p> </p> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Player Aiming](./Assets/Images/Thumb%20-%20future.png)](./Assets/Images/future.png)

- Part 7: Networked Projectiles 
 
    > Summary: Lorem ipsum dolor sit amet
    > - consectetur adipiscing elit
    > - sed do eiusmod tempor incididunt ut labore et dolore magna aliqua
<p> </p> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Networked Projectiles](./Assets/Images/Thumb%20-%20future.png)](./Assets/Images/future.png)

- Part 8: Firing Projectiles 
 
    > Summary: Lorem ipsum dolor sit amet
    > - consectetur adipiscing elit
    > - sed do eiusmod tempor incididunt ut labore et dolore magna aliqua
<p> </p> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Firing Projectiles](./Assets/Images/Thumb%20-%20future.png)](./Assets/Images/future.png)

- Part 9: Health Component 
 
    > Summary: Lorem ipsum dolor sit amet
    > - consectetur adipiscing elit
    > - sed do eiusmod tempor incididunt ut labore et dolore magna aliqua
<p> </p> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Health Component](./Assets/Images/Thumb%20-%20future.png)](./Assets/Images/future.png)

- Part 10: Health Display 
 
    > Summary: Lorem ipsum dolor sit amet
    > - consectetur adipiscing elit
    > - sed do eiusmod tempor incididunt ut labore et dolore magna aliqua
<p> </p> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Health Display](./Assets/Images/Thumb%20-%20future.png)](./Assets/Images/future.png)

- Part 11: Dealing Damage 
 
    > Summary: Lorem ipsum dolor sit amet
    > - consectetur adipiscing elit
    > - sed do eiusmod tempor incididunt ut labore et dolore magna aliqua
<p> </p> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Dealing Damage](./Assets/Images/Thumb%20-%20future.png)](./Assets/Images/future.png)

- Part 12: Coins 
 
    > Summary: Lorem ipsum dolor sit amet
    > - consectetur adipiscing elit
    > - sed do eiusmod tempor incididunt ut labore et dolore magna aliqua
<p> </p> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Coins](./Assets/Images/Thumb%20-%20future.png)](./Assets/Images/future.png)

- Part 13: Coin Wallet 
 
    > Summary: Lorem ipsum dolor sit amet
    > - consectetur adipiscing elit
    > - sed do eiusmod tempor incididunt ut labore et dolore magna aliqua
<p> </p> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Coin Wallet](./Assets/Images/Thumb%20-%20future.png)](./Assets/Images/future.png)

- Part 14: Coin Spawner 
 
    > Summary: Lorem ipsum dolor sit amet
    > - consectetur adipiscing elit
    > - sed do eiusmod tempor incididunt ut labore et dolore magna aliqua
<p> </p> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Coin Spawner](./Assets/Images/Thumb%20-%20future.png)](./Assets/Images/future.png)

- Part 15: Map Design 
 
    > Summary: Lorem ipsum dolor sit amet
    > - consectetur adipiscing elit
    > - sed do eiusmod tempor incididunt ut labore et dolore magna aliqua
<p> </p> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Map Design](./Assets/Images/Thumb%20-%20future.png)](./Assets/Images/future.png)

- Part 16: Combat Polish 
 
    > Summary: Lorem ipsum dolor sit amet
    > - consectetur adipiscing elit
    > - sed do eiusmod tempor incididunt ut labore et dolore magna aliqua
<p> </p> 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![Combat Polish](./Assets/Images/Thumb%20-%20future.png)](./Assets/Images/future.png)


### Section 3 - Connecting Online


### Section 4 - Gameplay Additions


### Section 5 - Online Matchmaking


### Setcion 6 - Multiplayer Teams