﻿

@code
    Layout = Nothing
End Code

<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <link href="~/Content/bootstrap.css" rel="stylesheet" type="text/css"/>
    <title>Index</title>
    <style>
        .btn a {color:white; text-decoration : none}
        body{ background-color : #F1F1F1 ;}
    </style>
</head>
<body>
    <div class="text-center">
       
            <h2>We're going to have an exciting party.</h2>
            <h3>And you are invited</h3>
        
        <div class="btn btn-success">
            @Html.ActionLink("RSVP Now", "RsvpForm")
        </div>
     
    </div>
</body>
</html>
