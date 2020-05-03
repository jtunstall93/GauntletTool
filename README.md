# GauntletTool
A basic tool for assisting beginners in completion of The Gauntlet on OSRS.

The numerical values can be changed as the player collects resources, and as they are changed, the progress bars to the right will fill, indicating how close the player is to required resources for the recommended set up.

The check boxes below can be checked as the player makes/acquires the recommended items for the basic set up. Once all items in the first box are checked and 2 of the 3 items in the weapon attachment column are checked, a text saying "Ready" will appear in the empty space, indicating that you are ready to take on the Hunllef.

Once the player has completed the gauntlet, they can press the reset button. This will reset all numerical values to 0, all progress bars to 0, and all checked items will become unchecked.

Clicking the custom bounds button will allow you to adjust the materials you wish to gain within the Gauntlet. This will create a "custom.txt" file in the "prefs" folder where your exe is located. If you do not have the prefs folder, create one and place it in the same directory as your exe. You can adjust the minimum bounds, but there isn't really any reason it should not stay at 0. Just wanted to be comprehensive.

In this new window for adjusting bounds, you can also restore the default values. This will load in the "default.txt" file in the "prefs" folder. If you do not have these, you can make one and insert whatever values you like, provided you follow the following format (base values I used in parentheses):

Weapon Frame Minimum Bound (0)
Weapon Frame Maximum Bound (2)
Ore Minimum Bound (0)
Ore Maximum Bound (10)
Bark Minimum Bound (0)
Bark Maximum Bound (10)
Wool Minimum Bound (0)
Wool Maximum Bound (10)
Grym Leaves Minimum Bound (0)
Grym Leaves Maximum Bound (2)
Food Minimum Bound (0)
Food Maximum Bound (16)
Shards Minimum Bound (0)
Shards Maximum Bound (560)

Also ensure that the file is saved as "default" in all lower case.
