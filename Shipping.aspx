<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shipping.aspx.cs" Inherits="ZenGaming.Shipping" MasterPageFile="~/ZenMaster.Master" %>


        
<asp:Content ID="Content1" ContentPlaceHolderID="PlaceHolder1" runat="server">
<body>
    
    <form id="form1" >
        <div>
            <section class="text-gray-500 bg-white body-font relative">
  <div class="container px-5 py-16 mx-auto">
      </div>
    <div class="flex flex-col text-center w-full mb-12">
      <h1 class="sm:text-3xl text-2xl font-medium title-font mb-4 text-green-500">Track Delivery</h1>
        <div class="flex mt-6 justify-center">
        <div class="w-16 h-1 rounded-full bg-green-500 inline-flex"></div>
      </div>
    </div>
        

    <div class="lg:w-1/2 md:w-2/3 mx-auto">
      <div class="flex flex-wrap -m-2">
         
          
           <label for="trkordr" class="text-lg text-green-500 font-bold">Tracking Code</label>
          <div class="container px-5 py-1 mx-auto">
              <asp:TextBox ID="trkorder" runat="server" OnClick="" BorderColor="#009933" BorderWidth="2px" TextMode="Number" Width="620px"></asp:TextBox>
      </div>
          <div class="relative">
       <div id="retship" runat="server"></div>

           </div>
            &nbsp;<div class="container px-5 py-5 mx-auto">
              <asp:GridView ID="order" runat="server" BorderColor="#00CC00" BorderStyle="Solid" BorderWidth="1px" Font-Names="Algerian" Font-Size="Small" GridLines="Horizontal">
              </asp:GridView>
      </div>
           
         
         <div class="p-2 w-full">
       <asp:Button ID="track" text="Track Order" runat="server" OnClick="track_Click" class="flex mx-auto text-white bg-green-500 border-0 py-2 px-8 focus:outline-none hover:bg-green-600 rounded text-lg" BorderStyle="None" />
        
        </div>
      </div>
    </div>
  </div>
    </form>
         </div>

         </div>


         </asp:Content>
