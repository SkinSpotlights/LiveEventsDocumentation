# LiveEventsDocumentation
Documentation of League of Legends Live Events API

Live Events API is a undocumentated API part of League of Legends that can be enabled via a config and a list of events that you wish to receive updates for.  **The API is only available in Spectator/Replays**.

To enable the API you need to navigate to the `Riot Games\League of Legends\Config\` folder and edit the `game.cfg` then add the following

```
[LiveEvents]
Enable=1
Port=34243
```

Next in `Riot Games\League of Legends\Config\` copy the `LiveEvents.ini` file from the repo into the folder, this list has all the current events in the latest build of the game, please note just because there is an event for it doesn't mean it will trigger in game, very few actually trigger.

The `LiveEvents.ini` file can be edited so you can remove events you're uninterested in, events like `OnKill` and `OnDie` will trigger twice because when a champion kills another champion one got the kill and one died so you may wish to remove `OnDie` and just read `OnKill`

In the repo is an example C# app which will connect to the API, run the app when the game is running watching a spectated game or a replay and it will start relaying response for events.

There currently is no exact list of Events which will trigger, the following I know will.  OnSpawn, OnKill, OnDamage, OnHeal, OnEmote, OnDragonKill etc, things which currently don't work at all are OnItem events apart from OnItemCallout which I don't know what relation it has and there is a config setting which throttles it to every once per 5 seconds.

Currently the LiveClientData API doesn't give exact Minion Count and the Events endpoint doesn't have Dragon/Herald/Baron kill Events, this LiveEvents API will give OnKill Events for Minions as well as OnKill Events for Jungle Mobs, Dragon, Herald and Baron so it could be used alongside the LiveClientData API in order to track these.
