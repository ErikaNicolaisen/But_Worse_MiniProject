The ReadMe is just the same as the Mini Project report:)

- But Worse – Mini Project
- Project Name: Flappy Feathers 3D
- Name: Erika Brinck Nicolaisen
- Link to YouTube video of the game: https://www.youtube.com/watch?v=OI4bDfEjh_g

Overview of the game:
The inspiration for the project is Flappy Bird. It has been developed as an endless runner created in a 3D world. It is a 3rd person game, where the bird is always in front of the camera and the camera follows the birds’ movement. The purpose of the game is the same as in the original Flappy Bird game: to increase the score when flying through the pipes and beat the high score. There has been added an element to the game: an angry bird, which follows and spawns in front of the bird. The player must shoot the angry bird before it hits the bird. The game ends when the bird hits the ground, the pipes or collides with an angry bird.
The main parts of the game:
-	Player: the bird. It flies upwards when the spacebar is pressed.
-	Camera: It follows the bird and allows the player to look around the field by moving the mouse and shoot precisely by aiming the camera and mouse at a target point.
-	Shooting: the projectile. The player can shoot small projectiles to destroy enemies.
-	Score: between pipes. The score increases when the bird flies between the pipes.
-	Enemies: angry birds. The enemies spawn on specific points and follow the bird. They can be shot when a projectile has hit them. When this happens particles spawn at the enemies’ position. They can collide and destroy the player immediately. 
-	Play field: a close off space. The player can only move forward on the z-axis and upwards on the y-axis. It is an endless runner.
-	Lives: The bird has one live and is destroyed when colliding with the ground, an enemy or the pipes.
Game features:
-	The position of the pipes and the enemies are randomly spawned.
-	A score tracking system motivates the player to beat their high score.
-	The player can shoot projectiles to destroy enemies. This adds an interactive combat element to the gameplay.

The different parts of the course
The game contains an interactive camera which the user can move using the mouse. The user can directly control the bird by pressing the spacebar and indirectly interact with enemies by clicking the mouse to shoot them. The bird has a small animation controlled by a boolean variable and an animator, which starts when the spacebar is pressed and stops when it is released. Both the bird, enemies and projectile have a Rigidbody component, enabling them to move and interact within the environment. The interactions between the bird and the pipes, ground and enemies are made by using the collision system with OnCollisionEnter. 
The enemies are controlled by a script to spawn and follow the player. Raycasting is used to point at the enemies with the camera and shoot projectile directly at them to destroy them. When the enemies are destroyed, it starts an explosion effect where particles spawn at the same place where the enemy is destroyed.
The different game objects have been given materials and textures. The game has UI elements such as the score, high score, start scene and game over scene. These two scenes also have buttons the user can interact with. 

Project parts
Scripts:
- DestroyObjects: As it is an endless runner, the objects must be destroyed with a Kill wall behind the player, to not create to many objects in the game.
- EnemyBehavior: Controls enemy movement towards the player.
- EnviomentMover: Moves the environment towards the player on the z-axis.
- PlayerBehavior: Controls the player and camera movement.
- PlayerHealth: Checks if the player collides with killing objects and spawns particles when the player has been destroyed.
- PlayerShooter: Uses raycasting for pointing at the enemies and shooting projectiles at them.
- Projectile: Spawns the projectile when the user shoots, destroys the enemy and spawn the particles.
- SceneController: Controls the different scenes in the game.
- ScoreManager: Controls the score and saves the high score.
- ScoreTrigger: Increases the birds’ score.
- Spawner: Spawns the different game objects and determines at what position and on which axis.

Models and prefabs:
- The Bird: https://sketchfab.com/3d-models/flappy-bird-dbd30f2677d24b14a1e45ee53a2a66c7
- The Angry Bird enemies: https://sketchfab.com/3d-models/red-classic-high-poly 4387c732382b4abf93fa816bbc42bf1c
- The Pipes: https://sketchfab.com/3d-models/flappy-bird-pipes65c48faa7d574b38a2b6637eca1fe4e5
- The Palm Trees: https://sketchfab.com/3d-models/palm-trees-55690379305145488e20afb05fc687e6
- The Ground: A plane created in Unity.
- The Projectile: A sphere created in Unity.
Materials and textures:
- Basic Unity Materials and textures from the downloaded models.
Scenes:
- Three scenes: Start scene, main scene and game over scene.

Time Management
- Tasks,	Time spend (in hours)
- Setting up Unity and Github,	1 hour
- Researching the game idea,	0.5 hour
- Searching for 3D models,	1 hour
- Creating the game in Unity, 14 hours
- Writing this report,	2 hours
- In total = 18 hours

Used Resources
-	Power Points and exercises from the course.
-	How to make a score and high score: https://youtube.com/watch?v=TAGZxRMloyU&t=484s
-	How to create particle system explosion on collision in Unity: https://www.youtube.com/watch?v=Th7BCP0aTLE
-	Raycast Unity 3d: https://www.youtube.com/watch?v=cUf7FnNqv7U
-	How to spawn objects in Unity: https://www.youtube.com/watch?v=aBzpvUXibw0
