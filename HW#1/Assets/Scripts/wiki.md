<h1>Software Requirements Specification<br>
for<br>
Disaster Response and Recovery</h1>
<br>
March, 27 2023
<br>
<br>

**Prepared by:**<br>
Group 2

**Members**<br>
- [Begüm Arslan](https://github.com/bounswe/bounswe2023group2/wiki/Beg%C3%BCm-Arslan)
- [Merve Gürbüz](https://github.com/bounswe/bounswe2023group2/wiki/Merve-G%C3%BCrb%C3%BCz) 
- [Cahid Enes Keleş](https://github.com/bounswe/bounswe2023group2/wiki/Cahid-Enes-Keleş)
- [Aras Güngöre](https://github.com/bounswe/bounswe2023group2/wiki/Aras-G%C3%BCng%C3%B6re)
- [Ersel Çanakçili](https://github.com/bounswe/bounswe2023group2/wiki/Ersel-Çanakçılı)
- [Egecan Serbester](https://github.com/bounswe/bounswe2023group2/wiki/Egecan-Serbester)
- [Mehmet Emin İpekdal](https://github.com/bounswe/bounswe2023group2/wiki/Mehmet-Emin-İpekdal)
- [Halil İbrahim Gürbüz](https://github.com/bounswe/bounswe2023group2/wiki/Halil-İbrahim-Gürbüz)
- [Ömer Şahin Albayram](https://github.com/bounswe/bounswe2023group2/wiki/Ömer-Şahin-Albayram)
- [Hasan Bingölbali](https://github.com/bounswe/bounswe2023group2/wiki/Hasan-Bingölbali)
- [Ramazan Burak Sarıtaş](https://github.com/bounswe/bounswe2023group2/wiki/Ramazan-Burak-Sar%C4%B1ta%C5%9F)
- [Mehmet Kuzulugil](https://github.com/bounswe/bounswe2023group2/wiki/Mehmet-Kuzulugil)

**Prepared for**<br>
BOUN - CMPE 352 - Spring 2023

# Table of Contents

## Revision History

|Name| Date | Reason for Change | Version |
|---------|---|:-------------:|----------:|
|Requirements|March, 23 2023|Document revised after work| 1.0 |

<details style=><summary><h2> Glossary</summary>

  - **Admin:** User who has the highest level of authority and who can control the application by banning users, editing posts, etc.
  - **Information:** Various types of information which circulate on the application (event, action, resource, need).
  - **Event:** Disaster related static happenings created by users (road is blocked, buildings are destroyed, power cut).
  - **Action:** Disaster related dynamic happenings created by users (dispatch of a relief team, search for survivors).
  - **Resource:** Any type of resource provided to demanders such as material resources (food, clothing, shelter, medical supplies, vehicles, instruments, etc.) or human resources (doctors, volunteers, etc.).
  - **Need/Demand:** Needs that are needed by demanders.
  - **User:** Anyone who is using the application. Can have static types (guest, authenticated, verified) or dynamic types (volunteer, creator, confirmer, demander, provider).
  - **Demander:** Users who need resources due to suffering damage from disasters.
  - **Provider:** Users who can provide material resources or him/herself as human resource to demanders.
  - **Creator:** A user that creates an information (event, action, resource, need).
  - **Confirmer:** A user who validates an information (event, action).
  - **Guest user:** Anyone who is using the application without registration. A guest user can view general information about disasters.
  - **Authenticated user:** Anyone who is using the application with signing up and entering personal information (name, surname, phone number, etc.). An authenticated user can report information (events, actions, resources, needs).
  - **Verified user:** Special users with extra authority (headman, pharmacist, etc.) who can prioritize actions, verify information, contact users, etc.
  - **Profile:** A page containing static data related to registered users (name, surname, phone number, etc.).
  - **Reliability scale:** An information sorting metric which measures the trustworthiness of the information based on feedback from other users.
  - **Interaction rate:** An information sorting metric which measures how many times the information has been viewed/shared/reacted by other users.
</details>

## 1. Functional Requirements

<details style=><summary><h3> 1.1 User Requirements</h3></summary>
 
* <h4> 1.1.1 Account Features</h4>

  * 1.1.1.1 Registration
      * 1.1.1.1.1 Users shall be able to create an account using a valid and unique email address, a unique username, their name, their surname and a password. 
  * 1.1.1.2. Log In
      * 1.1.1.2.1. Users shall be able to log into their account using their email or username, and password combination.
      * 1.1.1.2.2. Users shall be able to reset their password via email verification.
  * 1.1.1.3 Log Out
      * 1.1.1.3.1 Users shall be able to log out of their accounts.

* <h4> 1.1.2 Profile </h4>
  * 1.1.2.1. Users shall be able to edit their profile info.
  * 1.1.2.2. Users with the necessary authorization should be able to suggest system-level operational roles (which are attributes of user profiles) to other users. (?)
  * 1.1.2.3. Users shall be able to choose their proficiency.
  
* <h4> 1.1.3 User Actions</h4>
  * 1.1.3.1 Users shall be able to see the general information about disasters without logging in.
  * 1.1.3.2 Users shall be able to view information about disasters, including event types, resources available, and actions are taken.
  * 1.1.3.3 Users shall be able to report new disasters, such as fire, flood, or earthquake.
  * 1.1.3.4 Users shall be able to report required resources related to a disaster.
  * 1.1.3.5 Users should be able to receive notifications about available resources, or actions taken in their area.
  * 1.2.3.6 Users shall be able to search a resource, event or action, and receive results semantically related to the search
  * 1.1.3.7 Users shall be able to filter and sort information about events, resources, actions, and needs based on location, date, etc.
 
  * ##### 1.1.3.8 Authenticated User Actions:
    * 1.1.3.8.1 Authenticated users shall be able to display their own logs on their profiles.
    * 1.1.3.8.2 Authenticated users shall create actions, such as relieving needs, sending rescue teams, etc...
    * 1.1.3.8.3 Authenticated users shall verify their accounts by verifying their phone numbers.
    * 1.1.3.8.4 Authenticated users should delete their accounts.
    * 1.1.3.8.5 Authenticated users should change their usernames and passwords.
    * 1.1.3.8.6 Authenticated users should change their profile photos.
    * 1.1.3.8.7 Authenticated users shall be able to confirm or reject need logs, event logs and resource logs.
    * 1.1.3.8.8 Authenticated users shall be able to report malicious users.
    * 1.1.3.8.9 Authenticated users shall be able to report malicious users to the admins.
   
    * ##### 1.1.3.7.11 Verified User Actions: 
      * 1.1.3.7.11.1 Verified users shall be able to see the contact information of other users.
      * 1.1.3.7.11.2 Verified users shall be able to verify the authenticity of events, resources, and actions reported by other users to avoid duplicate or false information.
      * 1.1.3.7.11.3 Verified users should be able to prioritize actions based on the severity and urgency of the situation. 
      
* <h4> 1.1.4. Admin</h4>

  * 1.1.4.1 Admin user shall be able to create actions, such as relieving needs, sending rescue teams, etc...
  * 1.1.4.2 Admin user shall be able to see the contact information of other users.
  * 1.1.4.3 Admin user shall be able to view the misinformation reports.
  * 1.1.4.4 Admin user shall be able to accept or reject a misinformation report. When the misinformation report is accepted, the event will be removed.
  * 1.1.4.5 Admin user shall be able to remove events, actions, resources from the platform.
  * 1.1.4.6 Admin user shall be able to see authenticated and verified users' logs.
  * 1.1.4.7 Admin user shall be able to cancel verified users' verification or authenticated user's authentication. Once admin user cancel verification/authentication, they shall not be able to be verified or authenticated again.
  * 1.1.4.8 Admin user shall be able to see and recover cancelled verification or authentication.

</details>
<details><summary><h3>1.2 System Requirements</h3></summary> 

- <h4> 1.2.1 Profile Page</h4>

  - 1.2.1.1. A user profile shall have these attributes:

       - Name and surname (required)
       - Email            (required)
       - Date of birth   (optional)
       - Nationality     (optional)
       - ID number       (optional) 
       - Education       (optional)
       - Health status (Free format information about chronic diseases, allergies, regular medications etc.) (optional)
       - Blood type      (optional)
       - Address         (optional)
       - Phone           (optional)
       - Social media links (optional)
       - Expertise       (optional)
          - Definition
          - Experience level
          - Documented/certified by
          - Uses
              - Device, vehicle, instrument, etc.
              - Certificates (e.g. driver's license info)
       - Languages spoken (optional)
          - Language
          - Proficiency
       - Professions      (optional)
       - Other skills     (optional)

  - 1.2.1.2. System should show related actions, needs, resources and events to the authenticated user that has related proficiency. (i.e A doctor should see the event that medications arrive in the area.)
      

- <h4>1.2.2 Feedback System</h4>

  - 1.2.2.1: System shall allow users to report malicious users, need logs, event logs, and resource logs.
  - 1.2.2.2: System shall allow users to check for number of other users' confirmation or rejection about users, need logs, event logs, and resource logs.
  - 1.2.2.3: System shall carry on reports to administration system.
  - 1.2.2.4: System shall use the event,need, resource logs to score reliability of that logs.
  - 1.2.2.5: System shall not accept the banned accounts to register again.

- <h4>1.2.3 Resources </h4>
  
  - 1.2.3.1 Resource Entry
    - 1.2.3.1.1. Users shall be able to create, edit and update, or delete resource information.
    - 1.2.3.1.2. A resource shall have attributes:
      - Type, it can be predefined or other typed.
      - Subtype, it can be predefined or other type.
      - Location
      - Quantity 
      - username 
      - creation time
      - last update time
    - 1.2.3.1.3. A resource should have attributes:
      - different resources should have additional attributes if needed
      - reliability scale
      - available in certain times
      - status: allocated, used, cancelled
      - extra information
      - number of approvals
      - related needs 
        - related need are for predefined needs and resources.
    - 1.2.3.1.3. Users shall be able to replicate a created resource
  - 1.2.3.2. Resource Structure
    - 1.2.3.2.1. Resources should be organized in a structured manner to allow for easy access and management.
    - 1.2.3.2.2. The following predefined resources shall be included: food, clothing, accommodation, and human resources.
      - 1.2.3.2.2.1. Subtypes of food shall include:
        - Non-perishable items such as pasta, rice, canned goods, and other relevant items.
        - Baby food and similar items for infants and young children.
        - Dietary-specific items such as gluten-free, vegetarian, and other relevant items for individuals with specific dietary needs.
      - 1.2.3.2.2.2. Subtypes of human resources shall include:
        - Medical professionals such as doctors, nurses, pharmacists.
        - Emergency responders such as firefighters and police officers.
        - Support staff such as drivers, translators and other relevant roles necessary for disaster response.
      - 1.2.3.2.2.3. Subtypes of clothes shall include:
        - Seasonal clothing which is appropriate for the weather conditions: coats, hats, sweaters, gloves, shoes.
        - Underwear clothing which is necessary for personal hygiene.

- <h4>1.2.4 Events </h4>

  - 1.2.4.1 Events shall be created with following attributes:
    - 1.2.4.1.1 Type
    - 1.2.4.1.2 Creation time
    - 1.2.4.1.3 Creator username
    - 1.2.4.1.4 Location
    - 1.2.4.1.5 Interaction rate
    - 1.2.4.1.6 Related needs (Ex. enkaz altinda canli var, related needs: vinc, kurtarma ekibi vs)
    - 1.2.4.1.7 Confirmer username
    - 1.2.4.1.8 Last confirmation time
  - 1.2.4.2 The following predefined event types shall be included:
    - Road Blocked Event
  - Building With Live Human Collapsed Event
  - Building Without Live Human Collapsed Event
  - Building On Fire Event
  - 1.2.4.3 Events should be able to be edited and deleted by the creators. (I think 1.1.3 is a better place for this item)
  - 1.2.4.4 Events should be able to be deleted by admin users. (same as 1.1.4.5)
  - 1.2.4.5 Events should be able to be filtered based on type, location, creator username, etc. (same as 1.1.3.7)
  - 1.2.4.6 Events should be able to be sorted based on date, interaction rate, etc. (same as 1.1.3.7)

- <h4>1.2.5 Actions </h4>

  - 1.2.5.1 Actions shall be created with following attributes:
    - 1.2.5.1.1 Type
    - 1.2.5.1.2 Creation time
    - 1.2.5.1.3 Creator username
    - 1.2.5.1.4 Interaction rate
    - 1.2.5.1.5 Related resources, needs and events (Using these resources, handling these needs, related to these events etc)
    - 1.2.5.1.6 Confirmer username
    - 1.2.5.1.7 Last confirmation time
  - 1.2.5.2 Actions should be created with following attributes:
    - 1.2.5.2.1 Start location
    - 1.2.5.2.2 End location
  - 1.2.5.3 Actions should be able to be edited and deleted by the creators. (Bu 4 madde için yukarıdaki yorumlar geçerli)
  - 1.2.5.4 Actions should be able to be deleted by admin users if it contains duplicate or false information.
  - 1.2.5.5 Actions should be able to be filtered based on type, location, creator username, etc.
  - 1.2.5.6 Actions should be able to be sorted based on date, interaction rate, etc.
  
- <h4>1.2.6 Needs </h4>

  - 1.2.6.1 Needs shall be created with following attributes:
    - 1.2.6.1.1 Type: can be food, clothes, shelter, medical assistance, heat; should be flexible
    - 1.2.6.1.2 Creation time
    - 1.2.6.1.3 Creator/Demander username
    - 1.2.6.1.4 Location
    - 1.2.6.1.5 Quantity
    - 1.2.6.1.6 Urgency
  - 1.2.6.2 Needs should be created with following attributes:
    - 1.2.6.2.1 Reliability scale
    - 1.2.6.2.2 Approval number
    - 1.2.6.2.3 Current status
  - 1.2.6.3 Needs shall be edited and deleted by the creators.
  - 1.2.6.4 Needs should be able to be deleted by admin users if it contains duplicate or false needs.
  - 1.2.6.5 Users shall be able to replicate a created need
  - 1.2.6.6 Needs should be able to be filtered based on type, location, etc.
  - 1.2.6.7 Needs should be able to be sorted based on date, urgency, reliability scale, approval number, etc. By default, it will be sorted based on urgency to ensure that the most critical needs are addressed first.
  - 1.2.6.8 Needs should be flexible enough to accommodate changing needs and priorities over time, as the disaster situation evolves.
  - 1.2.6.9 Needs should allow users to assign themselves for providing the resource of it.(?)
  - 1.2.6.10 Status of needs should be timely updated and demanders shall receive status notifications for each update.

- <h4>1.2.7 Filter, sort </h4>
  
  - 1.2.7.1: User’s should filter the events based on emergency level so sources are used efficiently.
  - 1.2.7.2: User should sort the events based on recency. The default sort shall be based on interaction rate.

- <h4>1.2.8 Map visualization </h4>

  - 1.2.8.1 Maps shall contain some annotation on it. Annotations shall have different colors based on emergency level. 
  - 1.2.8.2: User shall zoom in and out. The annotations in the map should scale up and down accordingly.
  - 1.2.8.3: User’s location shall appear in the map so that users are able to understand what’s happening around them
- <h4>1.2.9 Annotation </h4>

  - 1.2.9.1 The system shall use W3C Geolocation API standard for implementing location-related information.
  - 1.2.9.2 The system shall provide all kinds of search functionality (e.g., search with filters, sort by date) for models.
  - 1.2.9.3 Users should retrieve results that are semantically similar to their queries.
  - 1.2.9.4 Users should be able to annotate different models, and annotations should comply with W3C Web Annotation Data Model.

- <h4>1.2.10 Notifications </h4>

  
  - 1.2.10.1: The system shall create in-app and push notifications.
  - 1.2.10.2: The system should create notifications, if they click “want to be notified” button on an information.
  - 1.2.10.3: The system should create notifications, if their profession might be impliyng that they can be a resource to a certain need. *
  - 1.2.10.4: The system should create notifications, if an event take place near to their address when they provide their address.
- <h4>1.2.11 Administrations </h4>
  
  - 1.2.11.1:  The system shall collect users's reports about other user in admin dashboard.
  - 1.2.11.2:  The system shall collect users's reports about a need log in admin dashboard.
  - 1.2.11.3:  The system shall collect users's reports about a resource log in admin dashboard.
  - 1.2.11.4:  The system shall collect users's reports about a event log in admin dashboard.
  - 1.2.11.5:  The system shall sort the reports according to number of reports on that report.
  - 1.2.11.6:  The system shall hold list of banned users and their phone numbers.
  - 1.2.11.7:  The system shall track the banned users by their phone number in order to prevent new sign up.
  - 1.2.11.8:  The system shall hold the admins' logs.

</details>

## 2. Non-Functional Requirements
- <h4>2.1 Availability </h4>

- <h4>2.2 Privacy </h4>

- <h4>2.3 Security </h4>

<details><summary><h4>2.4 Performance and Reliability</h4></summary> 



- 2.4.1. Response time: The system should respond to user requests within 5 seconds.
- 2.4.2. Throughput: The system should be able to handle a minimum of 500 concurrent users.
- 2.4.3. The platform shall support at least 5000 user accounts.
- 2.4.4. Fault Tolerance: The system should be designed to recover quickly from any failure, and data should not be lost during failures.
- 2.4.5. Capacity: The system should be designed to handle a large volume of data and user requests without any slowdowns.
- 2.4.6. Data integrity: The system should ensure that all data stored is accurate, complete, and consistent.
</details>

- <h4>2.5 Backup and Recovery (Consistency) </h4>


  

