# emuiibo usage

In this wiki you'll learn how to set up emuiibo, amiibos and how to use it properly on Atmosphere CFW.

**Important**: Make sure you always read the README and release changelogs (which are located on the release page)!

## Contents

- [Downloads](#downloads)
- [Set-Up](#set-up)
- [emutool](#emutool)
- [Controls](#controls)

## Downloads

You need to the following files:

- emuiibo (grab the latest release [here](https://github.com/XorTroll/emuiibo/releases))
- emutool (see emuiibo download above)
- Tesla (grab the latest [Tesla-Menu](https://github.com/WerWolv/Tesla-Menu/releases/latest) and [nx-ovlloader](https://github.com/WerWolv/nx-ovlloader/releases/latest))

## Set-Up

Make sure you downloaded all files mentioned above.

Create these folders on your SD (if not present):

- `sd:/emuiibo/amiibo`

- `sd:/switch/.overlays`

Extract all ZIP files and copy the folders on your SD card. It should look like this in the end:

- *emuiibo*: `sd:/atmosphere/contents/0100000000000352/exefs.nsp` and `/flags` folder
- *emuiibo overlay*: `sd:/switch/.overlays/emuiibo.ovl`
- *tesla-menu*: `sd:/switch/.overlays/ovlmenu.ovl`
- *nx-ovlloader*: `sd:/atmosphere/contents/420000000007E51A/exefs.nsp` and `/flags` folder

If you set up everything correctly, emuiibo is ready to load your amiibos you created via emutool (see below) or via raw .bin amiibo dump fules.

## emutool

You can create virtual amiibos via emutool (download link above) ready to use for emuiibo. You can choose and create from all available amiibo cards and figurines via emutool.

First we look on the left half of the program:

- In the first dropdown menu on top, you can choose amiibos from a certain collection. In the second dropdown menu next to it, you can choose any amiibo you want to create.

On the right half of the tool:

- You can choose a name for the amiibo you want to create, a custom directory name (if you uncheck "Use name as directory name" below it).

- You can then choose if you want the amiibo to use randomized UUIDs. This means that the console always read it as a new/unique amiibo (some games have restrictions to use the same amiibo only once or once a day). Note that this might cause issues for games which save data into amiibos, so avoid using it on those!

- Then, you can choose if you want to save the amiibo picture shown on the left into the amiibo folder (it will be saved as a PNG file).

**Optional**:

- If you have a FTP connection on your switch console, you can directly save your amiibo on your SD into: emuiibo/amiibo/

In the last step you click on "Create virtual amiibo" and choose a location, where you want to save it to. If an SD card with emuiibo is detected, the program will point to that SD's `/emuiibo/amiibo` folder.

Now you can copy the generated amiibo folder onto your SD card, in `sd:/emuiibo/amiibo/` or
`sd:/emuiibo/amiibo/<category>/` - you can sort virtual amiibos by categories this way!

## Controls

If you set up everything mentioned above, you're ready to use emuiibo ingame.

**Tip:** Enable it before you start a game, because it does not work in some games if you enable it after launching the game!

To open the Tesla overlay, hold down **L1 + DPAD-down** and then press **R3 (right stick)**. If you did it, Tesla Overlay will open on the left side of the screen. Now choose emuiibo.

**In the emuiibo overlay**:

- **Manage emulation*: enable/disable emuiibo via DPad or L3 (it´s disabled by default)

- *View amiibo*:

  - Choose your amiibo from root (`sd:/emuiibo/amiibo/`)

  - Choose your amiibo from a category (`sd:/emuiibo/amiibo/<category>/`)

To go back in the menus, just press **B** button.

After you selected an amiibo, you can see it's selected on top in the overlay and that it is "connected".

**Connected** is the equivalent of holding a real amiibo figurine/card on the NFC point. To **disconnect** the amiibo (the equivalent of removing a real amiibo from the NFC point), just select the same amiibo again.

To see if emuiibo is working ingame, check if emuiibo is intercepting the game when it's trying to access amiibos. If it's not, try launching the game with emuiibo enabled first.

**Example of use**:

1. Open the overlay and choose emuiibo
2. Enable emuiibo
3. Start the game
4. Navigate to the games NFC feature to use the amiibo and activate it
5. Open the overlay and choose your amiibo (will be *connected*)
6. The game should now register/make use of it
7. If the game tells you to remove the amiibo, *disconnect* it.
