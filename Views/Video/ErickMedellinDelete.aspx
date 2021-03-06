﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Video>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>ErickMedellinDelete</title>
</head>
<body>
    <h3>Esta seguro de borrar el siguiente Video?</h3>
    <fieldset>
        <legend>Datos del Video</legend>
        
        <div class="display-label">IdVideo:</div>
        <div class="display-field"><%: Model.IdVideo %></div>
        
        <div class="display-label">Nombre:</div>
        <div class="display-field"><%: Model.Nombre %></div>
        
        <div class="display-label">Url:</div>
        <div class="display-field"><%: Model.Url %></div>
        
        <div class="display-label">Fecha de Publicacion:</div>
        <div class="display-field"><%: String.Format("{0:g}", Model.FechaPublicacion) %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Borrar Video" /> |
		    <%: Html.ActionLink("Volver a la lista de videos", "/ErickMedellin") %>
        </p>
    <% } %>

</body>
</html>

