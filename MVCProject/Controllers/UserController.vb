Imports System.Web.Mvc

Namespace Controllers
    Public Class UserController
        Inherits Controller

        ' GET: User
        Function Index() As ActionResult
            'ViewData.Add(New KeyValuePair(Of String, Object)("MyActionName", "Index"))
            ViewData("MyActionName") = "Index"
            ViewBag.Title = "Index-Title"
            Return View()
        End Function

        Function UserProfile() As ActionResult
            'ViewData.Add(New KeyValuePair(Of String, Object)("MyActionName", "UserProfile2"))
            ViewData("MyActionName") = "UserProfile"
            ViewBag.Title = "UserProfile-Title"
            'Return View("Index")
            'Return Redirect("./Index")
            'Return Nothing
            'Return Redirect("../Home/About")
            Return Redirect("....")
        End Function
    End Class
End Namespace