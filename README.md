# gallery

gallery is a unity *educational* project used for interacting with 3D objects using STT, Virtual Buttons and Touch-To-Use functionality.

## Objects that You'll Interact With

You can add/change/create your own objects and add them to the models but the default in this project are the following:

1. Unity Built-in Objects:
   * Cube.
   * Sphere.  
   
2. External Assets' Objects:
   * Coffee.
   * Donut.   
   * Cake.
   * Potion.   
   * Crossbow.
   * Pumpkin (_because we all love halloween_).
 
## Description
There are **4** panels used with **2** virtual buttons.

Each panel will contain **2** objects and an object will be shown when you press either of them and **not** the **Non-Red** virtual button:

   * The _**first**_ panel will have _**green**_ colors and you can change between the following objects,
      - Cube
      - Sphere
   * The _**second**_ panel will have _**blue**_ colors and contains the following objects,
      - Coffee
      - Potion
   * The _**third**_ panel will have _**orange**_ colors and contains the following objects,
      - Donut
      - Cake
   * The _**fourth**_ panel will have _**purple**_ colors and contains the following objects
      - Crossbow
      - Pumpkin

To change the current panel, you can either: 

   * Click the _**Red**_ Virtual Button,
   * Or, Say _in clear words_ to your microphone the word **Change**, so that the Speech-To-Text algorithm works correctly and you'll see the word you said in the bottom-left corner of your screen in a white text button.
   
Also, you can **Scale** and **Rotate** and **Move** the object shown on your phone's touch screen using only **two** fingers.

## Example Use
### Changing Panels clicking Virtual Buttons
![](https://github.com/othub/gallery/blob/master/Screenshots/ChangePanelWithButtons.gif)

### Changing Panels using Voice Command
![](https://github.com/othub/gallery/blob/master/Screenshots/ChangePanelWithVoice.gif)

### Interacting and Moving and Scaling Object
![](https://github.com/othub/gallery/blob/master/Screenshots/MovingObject.gif)

## Development Requirements
- [Vuforia](https://developer.vuforia.com/downloads/sdk) for Unity.
- A valid Vuforia License.
- [Unity](https://unity3d.com/unity/whats-new/2019.4.13) 2019.4.13f1.
- Vuforia Image Database: You can pick your own but the one used for this project is [this](https://github.com/othub/gallery/blob/master/Assets/Images/cq5dam.web.1280.1280.jpeg). 
- [IBMWatson Speech-To-Text](https://github.com/watson-developer-cloud/unity-sdk) for Unity.
- Android SDK and NDK. 
- JDK. 

## License
[MIT](https://choosealicense.com/licenses/mit/)

## References
Some references used to configure the project.

[Vuforia](https://www.youtube.com/watch?v=ETAnttef7Zw): Configuring Vuforia for Unity and license managing.

[IBMWatson Speech-To-Text](https://github.com/watson-developer-cloud/unity-sdk): Configuring STT for Unity.

[Virtual Buttons](https://www.youtube.com/watch?v=Fgd21lbhikU): Configuring Vuforia's Virtual Buttons.
