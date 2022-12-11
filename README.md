
## Database Entity Relational Digram (ERD)

https://github.com/HeshamD/SimpleNote_WebAPI/blob/master/NoteTaking_ERD.pdf

## Concepts:

* Domain-Driven Design architecture
* Object-Relational Mapping (ORM) >>  Entity Framework (EF)
* LINQ
* Object-Oriented-Programing (OOP) 
* Authentication by using JWT web token 
* Async functions
 : An asynchronous method call is a method used in . NET programming that returns to the caller immediately before the completion of its processing and without blocking the calling thread.


## Code Explanation: 
- [X] Develop a simple note taking system and a web API front end
- [X] Users will work with notes
- [X] Notes may or may not belong to a project
- [X] Notes will have zero or more attributes
- [X] Use a simple authentication model (login and password)
- [X] This project does not deal with the administration of the users, projects, or attributes

### Users have the following properties:
- [X] UserId
- [X] Username (must be unique)
- [X] Password
- [X] Creation timestamp
- [X] Last login timestamp

### Notes have the following properties:
- [X] NoteId
- [X] Creation timestamp
- [X] Note text
- [X] Project
- [X] Attribute[]

### Projects have the following properties:
- [X] ProjectId
- [X] Name (must be unique)

### Attributes have the following properties:
- [X] AttributeId
- [X] Name (must be unique)

### The API have the following properties:
- [X] Login(username, password) - returns a token
- [X] Logout(token)
- [X] NewNote(NoteId, NoteText, Project, Attibute[])
- [X] UpdateNote(token, NoteId, NoteText)
- [X] DeleteNote(token, NoteId)
- [X] GetNotes(token, ProjectId, AttributeId[]) – Specifying a project will return notes for that
project only. Not specifying a project will return notes for all projects. Specifying attributeIds will return only notes that have those attributes. Not specifying attributeIds will return all notes regardless of attributes.
- [X] GetProjectNoteCounts(token) – Returns a count of notes for each project, an a count of notes not belonging to any project.
- [X] GetAttributeNoteCounts(token) – Returns a count of notes for each attribute, and a count of notes without attributes.


### API EndPoints:



+![](Endpoint.png)

