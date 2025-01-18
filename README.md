[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Committed After sending the email to Prof.Reid. I realized I saved the devlog locally on my laptop but did not commit the changes to the README.md to GitHub, I apologize again for the late turn-in.

In terms of objects, HW1 is composed of the UI of seeds planted (recording the number of seeds planted) and seeds remaining (display the number of seeds remaining), the game object of the player with a cat sprite, and the game object of the planted seed represented by a germinating plant. The player object, its attributes include moving speed and size; its actions include moving across four different directions using the WASD key and space bar to plant the seed. For the seeds object, its attribute includes size; its action is being planted by the player object when the space bar is pressed. These objects interact with each other. When the player controls the player object to move around the scene using the WASD key, they can use the space bar to plant seeds along the way. After a seed planting action, the UI will update the latest data displaying seeds remaining and seeds planted.

## Devlog
The following is how the breakdown is connected to the actual script writing and game building in Unity.

Player Movement: attributes _speed. Update() method for handling input of WASD key for movement using Unity’s Input.GetAxisRaw


Seed Planting: use the PlantSeed() method to spawn seed prefab _plantPrefab at the player’s position when the space bar is pressed checked in Update() and updates _numSeedsLeft and _numSeedsPlanted in the UI.

UI Updates: UpdateSeeds() method updates displayed text. This method is called when the game starts Start(), and whenever a seed is plantedPlantSeed().

Unity Scene

The Player gameObject has
- player script attached
- _speed
- _plantPrefab
- _plantCountUI 

The UI GameObject has
- PlantCountUI attached

The Seed prefab is 
- Instantiated at runtime


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for clearly connecting your HW1 break-down to the code that you wrote and the way you set up your Unity Scene! You'll earn full points for this Devlog.

Please make sure your in-class activity notes and your Devlog are sorted in to the proper sections- I moved some text around based on what I assumed was your activity VS. your Devlog. This will make it a lot easier for me to read. Also, you might want to check out the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
