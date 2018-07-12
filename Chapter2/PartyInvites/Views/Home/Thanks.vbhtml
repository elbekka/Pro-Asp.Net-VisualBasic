@ModelType PartyInvites.PartyInvites.Models.GuestResponse

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Thanks</title>
</head>
<body>
    <div> 
        <h1>Thank You , @Model.Name </h1>
        @code
            If Model.WillAttend = True Then
                @<p>great that you're coming. The drinks are already in the fridge!</p>
            Else
                @<p>Sorry to hear  that you  cant make it , but thanks for letting  us know</p>
            End If
        End Code
    </div>
</body>
</html>
