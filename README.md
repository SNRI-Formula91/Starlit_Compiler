# Starlit_Compiler
A Windows GUI tool for automating the updating and packaging of game translation files for THE iDOLM@STER Starlit Season.

# Installation Instructions
## Prerequisites
1. Download the localization files, and the programs `UnrealLocres.exe` and `UnrealPak.exe`. 
	If you want to make updates for a later game version, you will need to download localization files
	for the base version and every version after up to the one that is currently in use.
2. Create a folder that will hold all the localization files and the Starlit Compiler. This will be your **workspace**.
## Setup
1. Download the latest release of the `Starlit Compiler.zip` file.
2. Extract the contents of the release into your workspace directory.

# Usage
### Workspace path
Use the top field to specify the Workspace path. If you've already setup your workspace
with the steps from the installation, the location of this folder should be straightforward.
For those who have previously downloaded these files separately, this is referring to the
folder that contains the `pakchunk99-EngPatch` folder.
This folder path and its contents follow a strict pattern for the English patch creation process.

### CSV metadata
On the first startup, the app will need to fetch the CSV metadata (data about the URLs of the commu spreadsheets, file
location to download the file to, etc.) from the web. This can be done just by clicking the **Fetch .csv metadata** button.
If the default URL provided does not work, you can replace it with an alternative URL in the second text input box.

The metadata will be cached in the configuration, so the **Fetch .csv metadata** button does not need to be pressed
again in future uses of the app unless new DLC and new files have been added to the translation Google Drive.

## Updating
There are 3 main translation and importing update methods.
  (Note: All 3 updating methods will update the UI in the end in order to create the `.pak` mod files.)

* **UI Only**: Just click **Create .pak**. This only updates the UI files and creates the `.pak` `patch mod file.
* **Only selected files**: Click **Download Selected**, then **Convert CSVs**, then **Create .pak**. *This only updates the selected Commu files*. 
  * This is good for quickly updating a few files. Because the patching process injects text from `.csv` files, injecting files from files that have no new updates is redundant and unnecesary.
* **All Commu files**: Click **Download All**, then **Convert CSVs**, then **Create .pak**. Updates literally every possible existing file. 
  * Good to run for the very first time or if there are plenty of updates that justify updating a large number of files.
  * **Warning: This process takes a pretty long time due to the number of files.**

## Logging
The commands below will log their outputs to log files:
* **Create .pak**
  * `UI_update.log`
* **Convert CSVs**
  * `commu_import.log`

# Other notes
* You may place the `Starlit_Compiler.exe` file anywhere you please as long as the `Starlit_Compiler.exe.Config` file is also place in the same location. 
* The config file is used to remember the Workspace path and CSV URL metadata for future instances of using the application.
* If you want the compiler to immediately move the created `pakchunk99-EngPatch.pak` file to your game mod directory,
	you will need to make changes to the last line of the `Export_EngPatch.bat` file and uncomment the last 2 lines in that file.
