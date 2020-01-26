![Kingdom Hearts III Save Editor](docs/banner.png)

---

This is the repository for a Windows application that allows to modify decrypted saves of Kingdom Hearts series games.

The project offers a code library to help to create complex editors of scripts of any kind and on any operating system, plus a "in-house" editor compatible with Windows 7 or above (the only minimum requirement is .Net Framework 4.7.2 Rumtime). Not all the games are supported by the library and not all the library implementations has their editor. Yet.

| Game                   | Support     |
|------------------------| ------------|
| Kingdom Hearts Re: CoM | PS2/PS4     |
| Kingdom Hearts II      | PS2/PS3/PS4 |
| Kingdom Hearts 0.2     | PS4         |
| Kingdom Hearts III     | PS4         |

[![Download](https://img.shields.io/github/downloads/xeeynamo/kh3saveeditor/total.svg?)](https://github.com/Xeeynamo/KH3SaveEditor/releases)
![Last commit](https://img.shields.io/github/last-commit/xeeynamo/kh3saveeditor.svg?style=flat-square)


Here is a screenshot preview of how the editor in action looks like:

![demo](docs/demo1.png)

## Features in Kingdom Hearts III editor

* Tested support for the version 1.05 of Kingdom Hearts III
* Change game difficulty (even Critical Mode in version 1.03 or below)
* Make new saves compatible with older versions (advanced feature)
* Info and decorations (eg. game timer, save icons)
* Exp, Munny
* Manage story progression!
* Statistics (eg. save count)
* Inventory editor
    * Set items count between 0 and 255
    * Set flags (unseen, shop, collected)
    * Group editing
    * Search filter
        * Filter by name
        * Filter by quantity (eg `=0`, `>50`, `<99`)
        * Filter by unobtained (`obtained`, `!obtained`)
        * Filter by shop availability (`shop`, `!shop`)
* Sora and partners editor:
    * HP, MP, Focus, parameter boosts
    * Weapons equipped
    * Armors equipped
    * Accessories equipped
	* Ability support
* Records
    * Minigames
    * Flantastics
    * Shotlocks
* Photo gallery management
    * View the existing photos
    * Export one or all the photos
    * Import custom photo in the game
    * Delete all the photos
    
## Features in Kingdom Hearts II editor

* Shortcuts editor
* Character editor
    * Statistics
    * Equipment
* Character mod
* Experience and bonus level
* Difficulty
    
## Features in Kingdom Hearts 0.2 editor

* Multiple slot editing
* Change game difficulty
* Exp editor and level up
* Room mod
    
## Features in Kingdom Hearts Re: CoM

* Difficulty and system flags
* Card inventory
* Story progress
* Settings


## How to use it for PS4 games

You need first to get a decrypted save. There are two ways to achieve it:

1) Playstation 4 Save Mounter: If you have a PS4 with a HEN or Custom Firmware, you may want to use this free and fast tool: https://github.com/ChendoChap/Playstation-4-Save-Mounter

2) Save Wizard: If you do not have a custom firmware, you can obtain a copy of a decrypted save and re-encrypt it using the following paid software: https://www.savewizard.net/

Once you get your save, just open it using the KH3SaveEditor from File\Open, then save it with File\Save. If you want to transfer back the file on your Playstation 4, just follow the guide lines of the tool that you used for decryption

## How to use it for PS3 games

Decrypt your PS3 save game using the software `BruteForce Savedata` and modify the save from the KH3SaveEditor. Once you completed your changes, you need to save and encrypt the save back. It would be ideal to implement an encrypt/decrypt feature in the editor and it will come at some point.

## How to use it for PS2 games

The editor works on the raw save data from PS2 save game files. As long as you can extract the save slot from the memory card or from your favourite emulator, you can edit it. A native support for reading the save without extracting it from its container will come at some point.

## Contribute to make it better

This software is open-source, and every contribution is more than welcome!

If you want to add missing names, improve it or add new offsets, just clone the repository, do your change, test if it does work and create a pull request: we will review your change (no needs to be scared here) and we will merge it to this repo! Do not be shy on contribute, even for the smallest thing :)

## Issues or feature requestes

For every issue or feature request, please refer to [the issue page on GitHub](https://github.com/Xeeynamo/KH3SaveEditor/issues). Be as detailed as possible when creating an issue as it will help me to dig into the problem.

## Donations

My GitHub is opened to the [sponsor program](https://github.com/sponsors/Xeeynamo). If you feel that the editor helped you in some way or you would like to support it, please consider to [donate me](https://github.com/sponsors/Xeeynamo).

## To conclude

The code itself, the interface and the codes inside it are protected by GPL 3.0 license. In short, that means that for every change you made or code that you take from here, you need to make it open source somewhere, adding the original copyright statement and specify where the original code has been taken.

If you have more doubts about the GPL license, have a read to the following links:

https://tldrlegal.com/license/gnu-general-public-license-v3-(gpl-3)
https://simple.wikipedia.org/wiki/GNU_General_Public_License
