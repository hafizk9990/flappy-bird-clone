## Flappy Bird Clone - A 2D Unity & C# Game

In order to learn Unity 2D game development, I created my first-ever game, Flappy Bird. The game implements the several beginner-level concepts of Unity game engine and C# programming. I worked with and developed an understanding of the following aspects of the entire ecosystem.

### Technical Overview of the Game

- **Understanding Unity Game Engine Layout:** The project helped me learn the basic layout of Unity. I understood
  the hierarchy, scene, inspector, project and console windows.

- **Game Objects:** I understood that everything in the hierarchy panel of the engine was an object. Objects can be thought of as empty containers that we will fill with components.

- **Object Components:** By default, a "transform" component is available in Unity for all the
  objects. We can add more components by clicking on the "Add Components" button. Some of the objects that I used included the bird, its wings and the pipes through which the bird has to fly.

- **Famous Components:** Some of the most famous components in Unity are: RigidBody2D (adds weight to the object and makes it fall downwards), CircleCollider2d (helps catch collision events in the C# script), C# scripts (allow us to add logic to the game and respond asynchronously to the event-driven tasks)

- **C# Scripting:** It was really fascinating for me to work with 2D and 3D vectors in C#. Also, I learned how to create pointers (references) from the C# script to get awareness of other components in the object, as our script is unaware of those components at first.

- **Pre-Fabs:** I worked with pre-fabricated objects too. The obstacle pipes in the game are basically the pre-fabricated objects. It was nice to understand that a prefab was a standalone game object added as an object via C# script of another standalone Unity object.

- **UI Elements:** I also used some UI elements to create the "Game Over" screen. For example buttons, text (legacy), canvas, etc.

- **Triggers:** While working with colliders, triggers appeared to be a very amazing addition to my skill set. I used triggers alongwith event-driven programming to see if the bird had passed through the pillars to increase the user's game score. I used the `onTriggerEnter2D( .... )` function to fire the event and caught it in the parameters of the function.

- **Spawning:** I also understood how to spawn elements dynamically in the game. The pipes are spawned before entering the screen and then destroyed after leaving the viewing area on the screen. I also understood how dynamically spawned pre-fabs are non-existing statically in the game, and to import other files in them, we have to use different syntax in the `Start( ... )` method of C#.

- **Time.DeltaTime:** I also understood how different computing machines can have different refresh rates, resulting in the scnes moving faster / slower on different devices. To solve this issue, I understood the usage of `Time.DeltaTime`, as it gives us the lifespan of each frames on that machine. On a faster computer, this value will be smaller than on a slower computer, as more frames mean shorter lifespan of each of the frames in any given second, resulting in a smaller overall value whith which this value is being multiplied. Hence, I was successfully able to make my game frame rate-independent.

- **Layers & Tags:** I also worked with the concepts of layers. Assigning a separate layer to the bird and a separate layer to the wings allowed me to successfully increment the user's in-game scroe only when the collider for body (layer 3) collided with the triggers. Also, to import script dynamically in prefabs, tags were of profound help, as we are able to get the game object with a specific tag, like this: `gameObject.getObjectWithTag("Logic").getComponent<LogicScript>();`

Overall, it was an amazing learning experience. I could not leave in front of my laptop the entire time! I hope to create more games with even more amazing features, like sound effects, collision effects, animations, etc.
