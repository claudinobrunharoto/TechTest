# Final project for CS50: QRCode Generator

# Video Demo:
### https://www.youtube.com/watch?v=C7m1i0r6IOQ

# Description: 
### The developed project converts the text entered into the pre-defined field and, using an Application Programming Interface (API), converts it into QR code images. API used in our project: (https://documentation.image-charts.com)

# Colaborator: 
### Pedro Taiette Sato Librais

# Our goals and our propuorse 
### We decided to carry out our final project based on two main pillars: ease and objectivity.
### The motivation for carrying out our project was a very recurring event experienced by Pedro in his high school.
### Pedro had a teacher who used technological resources to teach in the classroom, however, she always faced some problems when trying to share the link to the online classroom content with students. She projected the link on the whiteboard in the room and the students needed to copy, character by character, its address. A very unexpected situation, which always provoked some complaints from students.
### Taking the first of the mentioned pillars (ease) as a basis, we sought to develop a clean and minimalist interface, aiming for    an easy and dynamic understanding of the tool.
### The second pillar (objectivity) guided us along a path to make the developed tool objective and practical. Based on this, anyone who uses it will be able to understand it quickly.
### Based on all the points mentioned above, we distributed our software to the teachers at the high school that Pedro attended and, in a short time, we obtained wonderful feedback from all the teaching collaborators at the institution. Such a tool has made copying links by hand a past history.

# Files used on QRCode Generator: 

### FinalProject.dpr -> this file contains the routines to start the project (Initialize, CreateForm, and Run methods).
### FinalProject.dproj -> it has all project settings in a XML format.
### FinalProject.exe -> a Windows executable (32 bits version). It is the result of the project.
### FinalProject.res -> an application's resource file. It stores some configuration, dependencies, security data, etc...
### Main.fmx -> it contains all the visual aspects of the main form.
### Main.pas -> it is the logic code of the main form writen in Object-Pascal.
### OptionsForm.fmx -> it contains all the visual aspects of the option form.
### OptionsForm.pas -> it is the logic code of the option form.
### FMX files are like the Front-End part of Delphi projects while PAS files are the Back-End code.

# Our code overview
![img1](https://github.com/claudinobrunharoto/TechTest/assets/58790242/27042f45-ad1b-4d8a-9dc9-a2a86ef970f6)
#### Image 1[^1]

![img2](https://github.com/claudinobrunharoto/TechTest/assets/58790242/a8ab7be1-c3b4-4180-87e4-47d135932a11)
#### Image 2[^2] 

![img3](https://github.com/claudinobrunharoto/TechTest/assets/58790242/077f5186-45d2-4513-b92f-288fe824d4b9)
#### Image 3[^3] 

[^1]: This part of the code concatenates the text entered with the settings to use it as part of the URL that will access the API.
[^2]: This part of the code is triggered upon receipt of the API response and loads the QR Code image on the screen.
[^3]: Sample of the QR Code generated after querying the API.
