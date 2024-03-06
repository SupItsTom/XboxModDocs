# Getting Started
This guide will run you through how to grab and edit Zones.

### Resources used in this guide
- **SWAT-556** Weapon Name Zone
- [PeekPokerRemastered](https://github.com/SupItsTom/XboxModDocs/raw/main/downloads/PeekPokerRemastered.zip), a wrapper to communicate with the Xbox 360 remotely.

## Step 1: Locating the zone with PeekPoker

Finding zones with the Remastered PeekPoker is as easy as typing the weapon name and pressing "Find". Let's do the SWAT-556 so show you the basics of how you can go about doing this.

In PeekPoker, Select the Option "PeekNPoke".

After you're in PeekNPoke, enter "A6766008" into your Address box, this is the beginning of the zone strings. For your length you'll want to do "07B944" as this cuts off ALL blank room in the hex, letting you see all of the zones without any complication.

After you've put in your Address & Length you're going to want to press "Peek" to view the console's memory.

You should see something like this to be on the right track
![PeekNPoke Finding Addresses](https://github.com/SupItsTom/XboxModDocs/raw/main/imgs/PeekNPokeSWAT.png)

## Step 2: Finding the weapon name

You should see a text box with a "Find" button, enter the weapon name "SWAT-556".

After you do that you should should see "SWAT-556" next to the weapon ID, like shown:

![SWAT-556 Result](https://github.com/SupItsTom/XboxModDocs/raw/main/imgs/PeekNPokeSWATFIND.png)

This should appear as "SWAT-556.WEAPON_SIG556". When editing zones be sure not to go over the original length of the weapon name as you could break the structure of the memory and break the weapon name! To learn more about how to bypass zones length requirements look into ![Advanced Zone Editing](https://github.com/SupItsTom/XboxModDocs/raw/main/docs/AdvancedZoneEdits.md).

## Step 3: Modifying the Zone in your program

On your program your IXboxConsole name will more than likely be "jtag" or "Console". We're going to be using "jtag" so Visual Studio does not get confused with the System.Console class. Select the first character of the weapon name, in this case the "S" in "SWAT-556", you should see an address at the top right of PeekNPoke called "Selected Address". Copy that and head over to visual studio. Since these are strings you're going to want to do WriteString to avoid complication.

Now, you'll want a function kind of like this

```csharp
jtag.WriteString(SWAT_ADDRESS,"^1SWAT");
```

Keep in mind the address will vary across different zones so make sure you're being careful!

## Next Steps

You should now have something like this! Feel free to explore different zone addresses as you've learned the basics!
![PeekNPoke Finding Addresses](https://github.com/SupItsTom/XboxModDocs/raw/main/imgs/SWATFINISHED.png)


> Section By: [krqus](https://github.com/krqus)