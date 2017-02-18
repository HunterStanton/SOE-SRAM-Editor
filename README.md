![SOE SRAM Editor icon](https://raw.githubusercontent.com/HunterStanton/SOE-SRAM-Editor/master/readme_image.png)

# SOE SRAM Editor
A SRAM (save RAM) editor for the Super Nintendo Entertainment System game, Secret of Evermore, which is one of my all-time favorite SNES RPGs. Couldn't get enough of it as a kid, even though I wasn't very good at it.

## What does this do?
Allow you to edit the SoE SRAM files produced by Snes9x. These contain everything - your XP, Level, Money, Weapon Levels, etc. They also contain a bunch of extra info that is not immediately obvious (such as which chests have been opened in certain rooms, and so forth). Modifying this data allows you to cheat, basically. There are genuine uses (such as renaming the boy or his dog, or lowering your level before any boss for a challenge) but for the most part, it is a cheating tool.

## Usage
Simply open the SRAM file and the editor will be populated with data from your save. Change it how you like, and then just hit save and your SRAM will be successfully modified.

## What is the point? Doesn't one of these already exist?
Yes, but I believe the other one hasn't been updated since 2008 (which isn't a bad thing if it worked well and still works) and it is in C++. This is in C#, and there is a Swift-based MacOS port planned.

## Credits
I couldn't have done this without this [super useful guide](http://games.technoplaza.net/soesrame/sram-doc.txt). It also describes the sanity check algorithm, which I had to implement to be able to modify the SRAM.

## Compatibility
This tool is a region-free tool. It does not matter which region your ROM is from, this will handle it.