## SetStat Function

### Resources Needed:
- [Cbuf_AddText Address](https://github.com/SupItsTom/XboxModDocs/blob/main/docs/cod/bo2/Addresses.md#main-addresses)


## Functions Needed:
***Cbuf_AddText Function***:
```csharp
public void AddText(IXboxConsole Console, string Command) {
  JRPC.CallVoid(Console, CBuf_AddText, new object[] {
    0,
    Command
  });
}
```
***SetStat Function***:
```csharp
public void SetStat(IXboxConsole Console, Progression statType, int value) {
  AddText(Console, $ "statsetbyname {statType} {value}");
}
```
***Progression Enum***:
```csharp
public enum Progression {
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

## How to Use:

> SetStat(jtag, Progression.SCORE, 1e24);