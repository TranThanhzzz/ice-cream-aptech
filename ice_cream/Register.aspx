<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Default2" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:50%" align="center">
        <tr  style="height:100px"><th colspan="2"><h3>Register Form</h3></th></tr>
        <tr  style="height:50px"><td>Username : </td><td><input class="input_form" type="text" name="username"/></td></tr>
        <tr style="height:50px"><td>Password : </td><td><input  class="input_form"  type="text" name="password"/></td></tr>
        <tr style="height:50px"><td>First Name : </td><td><input  class="input_form" type="text" name="firstname"/></td></tr>
        <tr style="height:50px"><td>Last Name : </td><td><input  class="input_form" type="text" name="lastname"/></td></tr>
        <tr style="height:50px"><td>Phone Number :</td><td><input  class="input_form" type="text" name="phone"/></td></tr>
        <tr style="height:50px"><td>Email : </td><td><input  class="input_form" type="text" name="email"/></td></tr>
        <tr style="height:50px"><td>Address : </td><td><input  class="input_form" type="text" name="address"/></td></tr>
        <tr style="height:50px"><td>Payment Option :</td><td>
            <select>
                <option>Choose type payment</option>
                <option>Visa</option>
                <option>Master</option>
                <option>Atm</option>
            </select></td></tr>
         <tr><td>Regular</td><td><textarea cols="40" rows="6" class="input_texearea"></textarea></td></tr>
        <tr><td><input type="checkbox" name="agree"/> I agree .....</td><td><input  type="submit" value="Register"/></td></tr>
        <tr><td></td><td></td></tr>
    </table>
</asp:Content>

