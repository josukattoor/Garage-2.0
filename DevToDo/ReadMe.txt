This readme file is all about how we will manage, plan out and go about building the project.

1. Branch Management: Start of with our personal branches. Once a feature is completed. Push that feature and the files that make the feature work. (Do not push incomplete files)
Once you want to push stuff from your personal branch, push it then into the testing branch (Here a selected member will run tests to verify that things work accordingly)
Once the tester and another member have verified [Feature] works as intended. It will then be pushed into the Master Branch.
TL;DR: personal branch --> Testing Branch ---> Master 

2. Project Guidelines: Write as clean and comprehensive code as possible. Try to keep null warnings and errors to a minimum. 

3. Copyright: Each and every member has the right to use the project as they please once the assigment is done. 

4. The Home site: Please see SampleCode.PNG to follow along. The Home Page will be made to have the GarageName (covered by black paint), A Check-In button (covered by Red),
A Check-out button (covered by blue). The Green text will be something along the lines of "Welcome to {GarageName} please check-in or check-out"

5. Check-in: When user presses Check-in they will be forwarded to the check-in page where they have to specify all the required information types. 
All values that cannot be null most have a requires field binded to it. While the nullable ones don't need it. 
{It's important to retrieve the users registration number as it will be used as their parking key within the ticket system.}
Controller: 

Views: 

Model:

6. Check-Out: Will enter the Check-out Page and in there we will have a page where you have to apply your registration number in order to checkout.
(User most have registered their vehicle before checking out)
{If successful it will write out a text saying: Check-Out successful}
{If it failed it shall then write out: An error has occured, please try again.}
{If the registration name is not sampled in the database write: This registration number is not checked in. Please check-in first.
Controller: 

Views: 

Model: