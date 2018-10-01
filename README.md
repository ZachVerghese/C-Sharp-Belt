# C-Sharp-Belt Exam Requirements: 
Overview: Create a website that function as an activity planner for all the users on the site (similar to meetup.com). This site should allow each user to create and plan different activities. Other users can then browse all activities and join ones they are interested in. Each individual activity page will also provide additional details include who is currently planning on attending. 

Login and Registration
- Front and Backend validations on inputs and uniqueness of db entries.
- All pages redirect to Login/Registration Page if visited by user who is not logged in.

Home
- Has listing of all current activities ordered by date they will occur.
- Option to Join activities not currently involved in, Leave activities already joined, or Delete activities you created.
- CANNOT join activities that have conflicting times/durations with an activity you are already joined.
- Activity information such as Date and Time, Duration, and Number of People Joined are listed.
- Activities only remain on the Home page if they have not expired. An activity will expire once its date/time have passed.

Adding Activities
- Validations on Activity title, time, date, duration, and description.
- Redirects to this activity's description page.

Activity Description Page
- Activity's information listed, also gives option to join, leave, or delete, depending on enrollment status of logged-in user.
- Lists out all users who are currently joined to the activity.


Deployment
Must deploy on AWS or Microsoft Azure, I deployed this project on Microsoft Azure.

Earned Black Belt.
