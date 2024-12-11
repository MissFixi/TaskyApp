# **TaskyApp **
Added FirstName and LastName to User class for future tests.<br>
Assumed that Users should be added to database.<br>
Tasks priority is in range 1-5 where higher number means higher priority.<br>
Divided Tasks into private (can be seen only by manager) and public (everyone sees them) by adding "IsPublic" attribute. <br>
Made different view in desktop app for Manager and for Employee<br>
<br><br>

## What should be added:
- Unit tests and integration tests
- Finished navigation between forms
- Sign out option
- Adding, deleting, finishing, editing tasks in desktop app
- App icon
- Better app design in general
- Options to edit or delete task when user clicks a task on list(list of user tasks, public tasks)
- Informing user about incorrect data format (currently added only when user tries to sign into desktop app)
- Pressing "enter" should execute same method as "Sign in" button
- Comments/documentation
<br>

## What could be changed/added:
- Sharing tasks for specific users instead of making them just private or public(eg. in additional table in database)
- Remembering information about who created and who finished task
- View of statistics for manager (grouped by months with actual nomenclature instead of numbers, maybe create diagrams)
- More secure placement of sql connection in Tasky project (shouldn't be in DbContext)
- Stored procedure and test data (users, tasks) created with code first approach
- Changing app language (now it's sort of mix of english and polish)
- Features in less forms (currently there are 7 forms that could be included in 1-3 forms)
- Additional attribute for tasks to store information about currently assigned person or people if we want to assign task to multiple people. Could also create new table to store information about all assigned people from StartDate to EndDate.