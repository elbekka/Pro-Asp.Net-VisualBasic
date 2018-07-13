@ModelType PartyInvites.PartyInvites.Models.GuestResponse

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <link rel="stylesheet" type="text/css" href="~/Content/Style.css" />
    <link rel="stylesheet" type="text/css" href="~/Content/bootstrap-theme.css" />
    <link rel="stylesheet" type="text/css" href="~/Content/bootstrap.css" />
    <title>RsvpForm</title>
</head>
<body>
    <div class="panel panel-success">
        <div class="panel-heading text-center"><h4>RSVP</h4></div>
        <div class="panel-body">
            @Using Html.BeginForm()
                @Html.ValidationSummary()
                @<text>
                    <div class=" form-group">
                        <label>Your name:</label>
                        @Html.TextBoxFor(Function(m) m.Name, New With {.class = "form-control"})
                    </div>
                    <div class="form-group">
                        <lavel>Your email:</lavel>
                        @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control"})
                    </div>
                    <div class="form-group">
                        <lavel>Your phone:</lavel>
                        @Html.TextBoxFor(Function(m) m.Phone, New With {.class = "form-control"})
                    </div>
                    <div class="form-group">
                        <label>Will you attend?</label>
                        @Html.DropDownListFor(Function(m) m.WillAttend, New SelectListItem() {
                                     New SelectListItem With {.Text = "Yes, I'll be there", .Value = Boolean.TrueString},
                                     New SelectListItem With {.Text = "No, I can't come", .Value = Boolean.FalseString}}, "Choose an option", New With {.class = "form-control"})
                        <br />
                        <input class="btn btn-success" type="submit" value="Submit RSVP" />
                    </div>
                </text>
            End Using
        </div>
    </div>
</body>
</html>