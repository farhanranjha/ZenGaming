<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="ZenGaming.LogIn" MasterPageFile="~/ZenMaster.Master" %>

 <asp:Content ID="C1" ContentPlaceHolderID="head" runat="server"> 
    <link href="https://unpkg.com/tailwindcss@^2/dist/tailwind.min.css" rel="stylesheet" />
    <title>Login</title>
        </asp:content>

  <%-- Login Body --%>
    <asp:Content ID="Content1" ContentPlaceHolderID="PlaceHolder1" runat="server">
    <section class="text-gray-600 body-font">
  <div class="container px-5 py-24 mx-auto flex flex-wrap items-center">
    <div class="lg:w-3/5 md:w-1/2 md:pr-16 lg:pr-0 pr-0">
      <h1 class="title-font font-medium text-3xl text-gray-900">Always at your service</h1>
      <p class="leading-relaxed mt-4" style="color:#10b981;">So your clutches and aces won't stop</p>
    </div>
    <div class="lg:w-2/6 md:w-1/2 bg-gray-100 rounded-lg p-8 flex flex-col md:ml-auto w-full mt-10 md:mt-0">
      <h2 class="text-gray-900 text-lg font-medium title-font mb-5">ZEN GAMING STORE</h2>
      <div class="relative mb-4">
        <label for="email" class="leading-7 text-sm text-gray-600">Email</label>
<%--        <input type="email" id="email" name="email" class="w-full bg-white rounded border border-gray-300 focus:border-green-500 focus:ring-2 focus:ring-green-200 text-base outline-none text-gray-700 py-1 px-3 leading-8 transition-colors duration-200 ease-in-out"/>--%>
        <asp:TextBox ID="email" runat="server" class="w-full bg-white rounded border border-gray-300 focus:border-green-500 focus:ring-2 focus:ring-green-200 text-base outline-none text-gray-700 py-1 px-3 leading-8 transition-colors duration-200 ease-in-out"></asp:TextBox>
      </div>
      <div class="relative mb-4">
        <label for="password" class="leading-7 text-sm text-gray-600">Password</label>
<%--        <input type="password" id="password" name="password" class="w-full bg-white rounded border border-gray-300 focus:border-green-500 focus:ring-2 focus:ring-green-200 text-base outline-none text-gray-700 py-1 px-3 leading-8 transition-colors duration-200 ease-in-out"/>--%>
        <asp:TextBox type="password" runat="server" id="password" name="password" class="w-full bg-white rounded border border-gray-300 focus:border-green-500 focus:ring-2 focus:ring-green-200 text-base outline-none text-gray-700 py-1 px-3 leading-8 transition-colors duration-200 ease-in-out"></asp:TextBox>
      </div>

      <asp:button ID="Login" text="Log In" runat="server" OnClick="LoginVerify" class="text-white bg-green-500 border-0 py-2 px-8 focus:outline-none hover:bg-green-600 rounded text-lg"/>
      <asp:Label ID="LoginResponse" runat="server" Text="" ForeColor="Green" Font-Bold="true"></asp:Label>
        <div id="returnMsg" runat="server"></div>
        <p class="text-xs text-gray-500 mt-3">Don't have an account? <a style="text-decoration:underline" href="https://www.facebook.com/">Sign Up</a></p>

        <asp:GridView ID="loginGrid" runat="server"></asp:GridView>
    </div>
  </div>
</section>

    </asp:Content>
       
<%--</html>--%>
