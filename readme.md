Welcome to machine learning environment and simulation in Unity Engine.
AI Agent have to reach target and cant touch the walls.

Above maze is very simple but it also took so much time to train it (about 500k episodes).
In Unity we can easy multiply our learn environment, 12 instances were no problem for PC with i5 4690K and GTX1060 with 16 GB RAM.



![ezgif-1-a3f4df5dcd42](https://user-images.githubusercontent.com/37455393/143767723-235b2101-3588-4720-bc6f-a884804ee6ee.gif)

![ezgif-1-0419bb8cf71a](https://user-images.githubusercontent.com/37455393/143767870-12803fd7-a94f-4482-aba4-a890f5f38ab0.gif)

Software and packages you will need to run Neural Network and simulation:

For host with Unity Engine:
- Python (==3.7.8),
- numpy (==1.19.5),
- Tensorflow (==2.6.0),
- Tensorboard (==2.7.0),
- Pillow (==8.3.2),
- Visual Studio 2019,
- Keras (==2.6.0),
- Opencv-Python (minimum version ==4.1.0.25),
- tqdm (==4.31.1),
- Unity Engine (2020.3.4f1),
- Unity ML Agents (==1.0.8 - important, different version doesnt work in this case),

For virtual environment (python venv):
- first, you will need to upgrade PIP to the newest version,
- Pytorch (==1.7.0) - this is little bit tricki, because we can already have pytorch on our venv, be carefull dont install 2 versions of torch,
- ML Agents,
- Pillow,
- Numpy, 
- tqdm. 
(try to install the same versions)

Optional (if we want to use our graphic card):
- NVIDIA cuDNN.
