using System;
using System.Reflection.Emit;

namespace C__Advance_Concept
{

  internal class layer_model
  {
        string Three_Layer_Model = "" +
            ":nThis term often refers to a conceptual division of an application into three main layers: presentation layer, business logic layer, and data layer.\r\nPresentation Layer: Deals with the user interface and user interaction.\r\nBusiness Logic Layer: Contains the application's logic and processes, often handling data validation, business rules, and workflows.\r\nData Layer: Manages the storage and retrieval of data from a database or other data storage systems." +
            "";
        string Three_Tier_Architecture = "" +
            "This is an architectural pattern used in software development and deployment. It divides an application into three interconnected layers: presentation, business logic, and data storage.\r\nPresentation Tier (or User Interface): Deals with user interaction and the presentation of information to the user.\r\nApplication (or Business Logic) Tier: Contains the application's logic and processes, handling tasks such as data processing, business rules, and communication between the presentation and data tiers.\r\nData (or Storage) Tier: Manages the storage and retrieval of data.";
        string sum= "" +
            "\r\nThe Model-View-Controller (MVC) architecture is another design pattern used in software development, and it also involves three main components: Model, View, and Controller. While it may sound similar to the \"3 layer model\" and \"Three-Tier Architecture,\" there are differences in their focus and responsibilities.\r\n\r\nModel:\r\n\r\nRepresents the application's data and business logic.\r\nResponsible for maintaining the data and the rules for manipulating that data.\r\nView:\r\n\r\nRepresents the user interface and is responsible for displaying data to the user.\r\nTypically observes the model and updates the interface when the model changes.\r\nController:\r\n\r\nActs as an interface between the Model and View.\r\nHandles user input, processes it (possibly modifying the model), and updates the view accordingly.\r\nComparison:\r\n\r\n3 Layer Model vs. MVC:\r\n\r\nThe \"3 layer model\" is a broader concept that divides an application into three layers: presentation, business logic, and data. It doesn't prescribe a specific pattern for organizing the code within those layers.\r\nMVC, on the other hand, is a specific architectural pattern that defines the roles and responsibilities of its three components (Model, View, Controller).\r\nThree-Tier Architecture vs. MVC:\r\n\r\nWhile both involve three components, Three-Tier Architecture is more concerned with the physical distribution of these components across different layers or servers. It emphasizes the separation of presentation, business logic, and data storage into distinct tiers.\r\nMVC is more focused on the logical organization of code within a single application, with an emphasis on separating concerns related to data, user interface, and user input."
  }


}