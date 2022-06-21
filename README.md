# MedsNotifier

### Concept
The concept of this project was to create the application which would help people to track and monitor the meds they take. Unfortunetly, only few features have been
realized by now.

### Technologies
The design of this application was completely created with **Blazor**. 
Authentication was made via *JSON Web Tokens* (JWT). Refresh Tokens also are supported. *Bearer* is set in local storage via JSRuntime. The new pair of tokens (Access + Refresh)
is generated everytime the current one is expired. So, the app gets all the user's claims from the JWT Access Tokens. The password was hashed by *BCrypt*.
*MongoDb* was used as a database. Its functionality was integrated into the project via *MongoDB.Driver*. The in this project DB is local, that't why you could come across
some difficulties if you want to run this app on your PC.

### How to use?
First of all, you have to pass the registration (if you haven't created your account yet).

![image](https://user-images.githubusercontent.com/75939461/174438830-9974939a-8196-48a6-8955-40d31b4b038f.png)

If you already have an account you have to log in.

![image](https://user-images.githubusercontent.com/75939461/174438944-48b94501-0c9f-4914-84f7-f8747644355b.png)

Here you can see basic application design:

![image](https://user-images.githubusercontent.com/75939461/174439125-e4390b4c-9530-4a4f-96b8-4b1f03af61b1.png)

On the "Meds" page you are able to add new meds/courses and also mark the times you take meds. The information dynamically changes everytime you press "Take meds!" button.
The circular progress bar shows the progress releatively to the amount of dosage left to take. When the progress is 100%, you get an informative message that the course 
is finished.
User can also delete the course.

![image](https://user-images.githubusercontent.com/75939461/174439156-1f66180c-63f3-42c6-8832-13f312121026.png)

There you can see the form which helps user to add new meds in his MedicineChest. Most of this data will be used in calculating percentage and other values. Color was 
added just for fun.

![image](https://user-images.githubusercontent.com/75939461/174439352-f7169bfa-cbf5-4e64-995a-9d79ad71dfd9.png)

Also I realized a Diary functionality to track the history of taking pills. Thus, user can see all the chronography of his courses. Also he can delete some of the points. This page looks like that:

![image](https://user-images.githubusercontent.com/75939461/174883910-f57b549c-18f7-45ea-9d92-2b339f348298.png)

Also, when user enters wrong endpoint, NotFound layout works, and you can see such a message:

![image](https://user-images.githubusercontent.com/75939461/174439470-c73f747d-e649-407a-b7a4-e0431f0d71dc.png)
