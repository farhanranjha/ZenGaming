<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="ZenGaming.ShoppingCart"  MasterPageFile="~/ZenMaster.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PlaceHolder1" runat="server">

             <%-- Shopping Cart --%>
     <div class="h-screen bg-gray-300">
    <div class="py-12">
        <div class="max-w-md mx-auto bg-gray-100 shadow-lg rounded-lg md:max-w-5xl">
            <div class="md:flex ">
                <div class="w-full p-4 px-5 py-5">
                    <div class="md:grid md:grid-cols-3 gap-2 ">
                        <div class="col-span-2 p-5">
                            <h1 class="text-xl font-medium ">Shopping Cart</h1>
                            <div class="flex justify-between items-center mt-6 pt-6">
                                <div class="flex items-center"> <img src="https://live.staticflickr.com/1081/4724257295_f3ae686ac6_q.jpg" width="60" class="rounded-full ">
                                    <div class="flex flex-col ml-3"> <span class="md:text-md font-medium">Xbox 360</span> <span class="text-xs font-light text-gray-400">#41551</span> </div>
                                </div>
                                <div class="flex justify-center items-center">
                                    <div class="pr-8 flex "> <span class="font-semibold">-</span> <input type="text" class="focus:outline-none bg-gray-100 border h-6 w-8 rounded text-sm px-2 mx-2" value="1"> <span class="font-semibold">+</span> </div>
                                    <div class="pr-8 "> <span class="text-xs font-medium">$69.99</span> </div>
                                    <div> <i class="fa fa-close text-xs font-medium"></i> </div>
                                </div>
                            </div>
                            <div class="flex justify-between items-center pt-6 mt-6 border-t">
                                <div class="flex items-center"> <img src="https://i.guim.co.uk/img/media/f58aa676496e9eaba611000477f28d0232fd91eb/0_165_3378_2027/master/3378.jpg?width=620&quality=85&auto=format&fit=max&s=f778a3ba06bb87279a9437669ff085e4" width="60" class="rounded-full ">
                                    <div class="flex flex-col ml-3 "> <span class="text-md font-medium w-auto">PlayStation 5</span> <span class="text-xs font-light text-gray-400">#66999</span> </div>
                                </div>
                                <div class="flex justify-center items-center">
                                    <div class="pr-8 flex"> <span class="font-semibold">-</span> <input type="text" class="focus:outline-none bg-gray-100 border h-6 w-8 rounded text-sm px-2 mx-2" value="1"> <span class="font-semibold">+</span> </div>
                                    <div class="pr-8"> <span class="text-xs font-medium">$109.99</span> </div>
                                    <div> <i class="fa fa-close text-xs font-medium"></i> </div>
                                </div>
                            </div>
                            <div class="flex justify-between items-center mt-6 pt-6 border-t">
                                <div class="flex items-center"> <img src="https://www.shophive.com/media/catalog/product/cache/3617b85921733ef3774cdbec091e1c0f/6/1/61v2p5xvpxl._ac_sl1000_.jpg" width="60" class="rounded-full ">
                                    <div class="flex flex-col ml-3 "> <span class="text-md font-medium">FIFA 20</span> <span class="text-xs font-light text-gray-400">#86577</span> </div>
                                </div>
                                 &nbsp;<div class="container px-5 py-5 mx-auto">
              <asp:GridView ID="ocart" runat="server" BorderColor="#00CC00" BorderStyle="Solid" BorderWidth="1px" Font-Names="Algerian" Font-Size="Small" GridLines="Horizontal">
              </asp:GridView>
      </div>
                                <div class="flex justify-center items-center">
                                    <div class="pr-8 flex"> <span class="font-semibold">-</span> <input type="text" class="focus:outline-none bg-gray-100 border h-6 w-8 rounded text-sm px-2 mx-2" value="1"> <span class="font-semibold">+</span> </div>
                                    <div class="pr-8"> <span class="text-xs font-medium">$29.99</span> </div>
                                    <div> <i class="fa fa-close text-xs font-medium"></i> </div>
                                </div>
                            </div>
                            <div class="flex justify-between items-center mt-6 pt-6 border-t">
                                <div class="flex items-center"> <i class="fa fa-arrow-left text-sm pr-2"></i> <span class="text-md font-medium text-green-500"><a href="Homepage.aspx">Continue Shopping</a></span> </div>
                                <div class="flex justify-center items-end"> <span class="text-sm font-medium text-gray-400 mr-1">Subtotal:</span> <span class="text-medium font-bold text-gray-800 "> $209.99</span> </div>
                                 </div><div class="p-2 w-full">
                                        <button onclick="document.location='Checkout.aspx'" class="flex mx-auto text-white bg-green-500 border-0 py-2 px-8 focus:outline-none hover:bg-green-600 rounded text-lg"><a href="Checkout.aspx"> Check Out</a></button>
                                  </div>
                            </div>
                           
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
    </form>
</asp:Content>
