# Starlit_Compiler
A Windows GUI tool for automating the updating and packaging of game translation files for THE iDOLM@STER Starlit Season.

# Installation Instructions
## Prerequisites
1. Download the localization files. If you are want to make updates for a later game version, you will need to download localization files for the base version and every version after up to the one that is currently in use.
2. Create a folder that will hold all the localization files and the Starlit Compiler. This will be your **workspace**.
## Setup
1. Download the latest release.
2. Extract the contents of the release into your workspace directory.

# Usage
Use the top two fields to specify the Workspace and Commu-kit folder paths. If you already setup your workspace with the steps from the installation, the locations of these folders should be straightforward.
For those who have previously downloaded these files separately the two folder paths are referring to the following:
* **Workspace path**: The folder that contains the "pakchunk99-EngPatch" folder. This folder path and its contents are follow a strict pattern for the English patch creation process.
* **Commu-kit path**: The folder that contains the **Commu-kit.exe** and its dependencies.

# Other notes
* You may place the **Starlit_Compiler.exe** file anywhere you please as long as the **Starlit_Compiler.exe.Config** file is also place in the same location. 
* The config file is used to remember where your Workspace and Commu-kit paths are set for future instances of using the application.
* If you want the compiler to immediately move the created **pakchunk99-EngPatch.pak** file to your game mod directory, you will need to make changes to the last line of the **Export_EngPatch.bat** file and uncomment the last 2 lines in that file.
