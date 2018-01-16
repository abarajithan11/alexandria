# Alexandria

As a Library automation System, Alexandria allows the librarians to perform the functions of a manual information system of a library faster, easier and in a more advanced manner. Those basic functions include adding new books to catalogue, adding new members, viewing book & member details, removing books and members, lend books to members, receive books from members, calculate fines etc. These operations are explained in detail in the user guide (see)
In addition to those basic operations, some more advanced and useful functionalities have been built into Alexandria: The Integrated Library System. Few of those notable features are listed below.

1.	Preferences

Preferences are settings that are stored in the database and can be modified by an administrator user account. Some of them are:

•	Fees to be charged from a new member

•	Fees to be charged for a membership renewal

•	Maximum no. of days a book is allowed borrowed

•	Fines per day for a book

•	No. of months in which a membership expires

•	Maximum no. of books allowed for a member

•	No. of days of lending after which an alert should be raised

These settings can be set separately for an adult member and a child member. The minimum age for an adult membership can also bet set.

2.	User Accounts
User Accounts can be created with a username and password combination under one of the two user types: administrator and librarian. These accounts can be created, modified or deleted from the preferences window by an administrator.  The credentials for these accounts are stored in the database and the database is secured with a master password ().
The application can be opened in three modes. A member can login without a username and password, but can only access the Check-In-Out and BookFinder windows. Librarians and administrators are required to provide their credentials to login. Librarian can manage Books, Members and Issues only, while an administrator has access to all of the windows, especially transaction details, preferences, Member logbook and statistics.


3.	Alert Notifications
Notifications are issues that have not been returned past the alert time. Members may have forgotten to return these issues or these books may have been stolen. When the application is launched, the database is scanned for such issues and if such records have been found, a window with book details such as price and member’s ID is shown to a librarian or administrator. Details of a member, book or title can be viewed by clicking respective cells in the window. The member can be reminded by getting the contact information or the book can be removed and member can be added to blacklist.

4.	Blacklist (Blocked Members)
Members who are suspected for a book theft or other security reasons can be added to blacklist and blocked. Whenever these members try to use the library (check-in, borrow, return or extend a book) an alert is raised and the librarian is notified to take necessary actions.
In addition to that, when such members try to apply for a new membership, the database is scanned for an NIC or email ID match and an alert is raised. Also, when somebody registers with same address, phone no. or work address the librarian is notified and the librarian may inquire the new member about the whereabouts of the blocked member.

5.	Statistics
In addition to general statistics, the most active members, mostly read titles, authors and genres are also listed in the statistics window. This may be less useful for traditional libraries, but innovative libraries may award the top members to encourage them and consider the trending statistics when choosing new books for the library.
Other minor features are:
•	Account Fines: Storing unpaid book fines to members account (see) 
•	Member Check In, Check Out.
•	Ability to add several books under one title
•	Allow members to report a lost book and pay certain times the price of the book.
