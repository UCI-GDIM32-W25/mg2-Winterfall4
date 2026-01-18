[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
What I planned during W2 Activity:

- There were 3 major game objects being: penguin, UI, and the coin.

- Penguin:

    - sprite
    - jump/translate
    - rigidbody2d
    - collider2d
    - script

- UI:
    - script
    - textmesh
    - instantiate coin
    - change score

- Coins:
    - sprite
    - prefab

What I actually did:
    - There are 4 major scripts that I wrote for this game: player, spawn, destroyer, coin

    - Player:
        - If space bar is pressed, checks to see if grounded and if so, then it will jump.
        - When the player collides with a coin, it changes the score on the UI.

    - Coin:
        - Always moving to the left

    - Spawn:
        - Spawns coins at random

    - Destroyer:
        - Destroys the coins that it touches

Reasoning:
When actually working on the game, there were several things that I realized I did not think through on my original plan. I realized that the coin had to have a script of its own to allow it to be able to move left on the screen. I also realized that it would be better to have the player control the score on the UI since it is always going to be in the game and the player is the one getting the points so it would be better to keep the code in same script. I also realized that I would need two game objects to spawn and destroy the coins.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites