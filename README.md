# Starlit_Compiler
A Windows GUI tool for automating the updating and packaging of game translation files for THE iDOLM@STER Starlit Season.

# Installation Instructions
## Prerequisites
1. Download the localization files. If you are want to make updates for a later game version, you will need to download localization files for the base version and every version after up to the one that is currently in use.
2. Create a folder that will hold all the localization files and the Starlit Compiler. This will be your **workspace**.
## Setup
1. Download the latest release of the **Starlit Compiler.zip** file.
2. Extract the contents of the release into your workspace directory.

# Usage
Use the top two fields to specify the Workspace and Commu-kit folder paths. If you already setup your workspace with the steps from the installation, the locations of these folders should be straightforward.
For those who have previously downloaded these files separately the two folder paths are referring to the following:
* **Workspace path**: The folder that contains the "pakchunk99-EngPatch" folder. This folder path and its contents are follow a strict pattern for the English patch creation process.
* **Commu-kit path**: The folder that contains the **Commu-kit.exe** and its dependencies.
## Updating
There are 3 main translation and importing update methods:
* **UI Only**: This only updates the UI files and creates the *.PAK* patch mod file. All 3 updating methods will update the UI in the end in order to create the *.PAK* mod files.
* **Only selected**: This **only updates the selected Commu files**. This is good for quickly updating a few files. Because the patching process injects text from *CSV* files, injecting files from files that have no new updates is redundant and unnecesary.
* **All Commu files**: Updates literally every possible existing file. Good to run for the very first time or if there are plenty of updates that justify updating a large number of files. (**Warning: This process takes a a pretty long time due to the number of files...**)
## Logging
Different log files will be written depending on the method used to compile a patch:
* **Only Update UI** --> UI_update.log
* **Import Selected** --> quick_update.log, commu_import.log, & UI_update.log
* **Import All** --> full_update.log, commu_import.log, & UI_update.log

# Other notes
* You may place the **Starlit_Compiler.exe** file anywhere you please as long as the **Starlit_Compiler.exe.Config** file is also place in the same location. 
* The config file is used to remember where your Workspace and Commu-kit paths are set for future instances of using the application.
* If you want the compiler to immediately move the created **pakchunk99-EngPatch.pak** file to your game mod directory, you will need to make changes to the last line of the **Export_EngPatch.bat** file and uncomment the last 2 lines in that file.
