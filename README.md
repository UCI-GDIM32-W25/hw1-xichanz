[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!

Committed After sending the email to Prof.Reid. I realized I saved the devlog locally on my laptop but did not commit the changes to the README.md to GitHub, I apologize again for the late turn-in.

In terms of objects, HW1 is composed of the UI of seeds planted (recording the number of seeds planted) and seeds remaining (display the number of seeds remaining), the game object of the player with a cat sprite, and the game object of the planted seed represented by a germinating plant. The player object, its attributes include moving speed and size; its actions include moving across four different directions using the WASD key and space bar to plant the seed. For the seeds object, its attribute includes size; its action is being planted by the player object when the space bar is pressed. These objects interact with each other. When the player controls the player object to move around the scene using the WASD key, they can use the space bar to plant seeds along the way. After a seed planting action, the UI will update the latest data displaying seeds remaining and seeds planted.

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
