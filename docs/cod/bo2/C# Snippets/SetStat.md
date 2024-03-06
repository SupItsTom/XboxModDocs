## SetStat Function

### Resources Needed:
- [Cbuf_AddText Address](https://github.com/SupItsTom/XboxModDocs/blob/main/docs/cod/bo2/Addresses.md#main-addresses)


## Code Examples:
***Cbuf_AddText***:
```csharp
Console.CallVoid(0x824015E0, 0, cmd);
```
***SetStat example***:
```csharp
Cbuf_AddText("statsetbyname {Stats.KILLS} 1337");
```
***Progression Enum***:
```csharp
public enum Stats {
  RANKXP,
  SCORE,
  KILLS,
  DEATHS,
  ASSISTS,
  HEADSHOTS,
  TEAMKILLS,
  SUICIDES,
  TIME_PLAYED_TOTAL,
  KDRATIO,
  WINS,
  LOSSES,
  TIES,
  CUR_WIN_STREAK,
  WLRATIO,
  HITS,
  MISSES,
  TOTAL_SHOTS,
  ACCURACY,
  PLEVEL
}
```
