### Requirements to run the project:

1) Install Visual Studio 2019 (for library and API);
2) .Net Framework 4.7
3) .Net 5.0
4) NodeJs
5) Visual Studio Core (for React Application)

### Open the project in Visual Studio 2019
There is the file "TrueLayerTest.sln" to open the project in Visual Studio in the folder.

Run "Web API.” It is necessary to turn on the server and expose the service. 


### Open the React Project in Visual Code
In the folder, there is the folder 'my-app':
1) Open the terminal and use the command: cd "path of my-app.”
2) Use the command "code."
3) Use the command npm start (the browser will open and shows the page to start to test the application) 
4) Text the pokemon’s name and click on the right button. 
### N.B. You do not use enter button of the keyboard, the event does not work, and I did not have time to handle it.
## The web page is responsive.

The project in Visual Studio is composed in the following layer:

1) TrueLayePokemon.Library
In this library has been implemented the call to the APIs. In this case, the functionalities can be reused in different projects or solutions.

2) TrueLayePokemon.UniteTest
To make the automation test, I used the UniteTest project of Visual Studio. I have implemented the automatized test of the functions implemented in the library.

3) TrueLayePokemon.WebAPI
I have implemented the API to use them in ReactJS. In this case, the two different technologies can communicate between them.
## I did not make the automatized test for APIs.

The project for React ( I never implemented in React, and in advance, I say sorry for some mistakes).
I have implemented the front end with bootstrap (I used some CSS code), and I used Javascript to handle the result from API.

