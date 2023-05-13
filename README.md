# ASP.NET MVC Demo Application Project

### Setup ###
- ASP.NET Web Application for Visual C#
- Leave	**Create directory for solution** unchecked.
- Create new **Git repository** checked.
- Select Empty template.
- Select **MVC** for **Add folders**..

### Adding a Controller ###
- Right click `Controllers` folder in the project > Add > Class
- Filename for a controller class must end in **Controller** so Visual Studio can distinguish controllers from regular classes.
- Our controller must inherit from the MVC controller base class and include using `System.Web.Mvc`
- Controller must be public so its accessible.

### Adding View ###
- In **View** folder right click Add > MVC 5 View Page (Razor) to add a view or right click on a controller method.
- You may need to create a folder for each controller and have the view be inside that folder. See **View/Values/Index.cshtml**
- **Razor** is a view language allowing you to create views by combining C# and HMTL.

### Adding Data Model ###
- Data modeling is the noun in a website
- Models > values.cs

# RestApi Documentation.

1.http://localhost:8080/add/book
 
POST /Addvalue
Accept: application/json
Content-Type: application/json

{
"value" : 10,
}

# Response

1.Value Added

