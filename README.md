RAG

rag is a game where you have to fight to survive between two great ancient powers.

v1 basic movements and heightmaps for point to click movement

v2 interactable's put in place, so far there are three but it is modular and very easy to add more. 
   so far I have the base interaction which lets the game know the player is doing something, but what? thats what the child derivitives are for.
   I have action for turning on a light or opening a door, I added ITEM interaction for when a player is going to loot a sword or lootable item, I added NPC for if a player is to converse with an NPC of any kind ( I can very easily create hostile and friendly derivitaves stemming from the NPC)  and finally I added READ for when a player is reading a sign or something like that.

   the interactbles let me know exactly what the player is interacting with so I can set up correct UI's to follow up with the action.

   also made it so the player does not run exactly to the interacted object but rather a litle bit in front.

   also added UI for dialogue but was just messing with it and it does not function

   finally there is no visual queue for when you are interacting but if you check the console the correct interactions are sent.
   
   v3 created framework for singleton design pattern
   
   did so by creating head script and 3 following scripts allowing for the intake of a name which changes the player name displayed on screen however I have no use for this YET as I have no dialogue because there is no NPC to talk to yet. However this will make it super easy for when an NPC is talking to a player that it will say the players inputted name as each player will give its player a different name. 
   
   Also added ambient sound to the forest setting
