<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DayPilotTest.Views.Home.Default" %>
<%@ Register Assembly="DayPilot" Namespace="DayPilot.Web.Ui" TagPrefix="DayPilot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <daypilot:daypilotcalendar 
            id="DayPilotCalendar1" 
            runat="server" 
            DataStartField="eventstart" 
            DataEndField="eventend"
            DataTextField="name" 
            DataValueField="id" 
            Days="7" 
            OnEventMove="DayPilotCalendar1_EventMove" 
            EventMoveHandling="CallBack"
        >
        </daypilot:daypilotcalendar>
        <div>
        </div>
    </form>
</body>
</html>
