﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Rossyv</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdVideo
            </th>
            <th>
                Nombre
            </th>
     
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "RossyvEdit", new { id=item.IdVideo }) %> |
                <%: Html.ActionLink("Ver Detalles", "RossyvDetails", new { id=item.IdVideo })%> |
                <%: Html.ActionLink("Borrar", "RossyvDelete", new { id=item.IdVideo })%>
            </td>
            <td>
                <%: item.IdVideo %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
         
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Nuevo video", "Create") %>
    </p>

</body>
</html>

