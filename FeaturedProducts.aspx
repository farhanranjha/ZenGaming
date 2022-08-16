<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FeaturedProducts.aspx.cs" Inherits="ZenGaming.FeaturedProducts" MasterPageFile="~/ZenMaster.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PlaceHolder1" runat="server">
    <%-- Main Body --%>
    <form id="form1" >
        <div>
            
            <section class="text-gray-500 bg-white body-font">
  <div class="container px-5 py-24 mx-auto">
    <div class="text-center mb-20">
      <h1 class="sm:text-3xl text-2xl font-medium title-font text-green-500 mb-4">Our Recommended Products</h1>
      <p class="text-base leading-relaxed xl:w-2/4 lg:w-3/4 mx-auto text-gray-500 text-opacity-80">Collection of our finest products as recommended by our customers and us.</p>
      <div class="flex mt-6 justify-center">
        <div class="w-16 h-1 rounded-full bg-green-500 inline-flex"></div>
      </div>
    </div>
    <div class="flex flex-wrap sm:-m-4 -mx-4 -mb-10 -mt-4 md:space-y-0 space-y-6">
      <div class="p-4 md:w-1/3 flex flex-col text-center items-center">
        <img class="circularbox" src="https://atreboot.com/wp-content/uploads/2020/11/619BkvKW35L._SL1500_.jpg" alt="ps5" />
        <div class="flex-grow">
          <h2 class="text-green-500 text-lg title-font font-medium mb-3">Sony PlayStation 5</h2>
          <p class="leading-relaxed text-base">Play Has No Limits™PlayStation®5 The PS5™ console unleashes new gaming possibilities that you never anticipated.</p>
          <a href="ProductPage.aspx" class="mt-3 text-green-400 inline-flex items-center">Learn More
            <svg fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" class="w-4 h-4 ml-2" viewBox="0 0 24 24">
              <path d="M5 12h14M12 5l7 7-7 7"></path>
            </svg>
          </a>
        </div>
      </div>
      <div class="p-4 md:w-1/3 flex flex-col text-center items-center">
          
          <img class="circularbox" src="https://cdn2.unrealengine.com/battle-pass-chapter-2-season-6-1920x1080-dc8eb73dc494.jpg" alt="Fortntie" />
          
        <div class="flex-grow">
          <h2 class="text-green-500 text-lg title-font font-medium mb-3">Fortnite</h2>
          <p class="leading-relaxed text-base">Fortnite is an online video game developed by Epic Games and released in 2017. A battle royale game in which up to 100 players fight to be the last person standing</p>
          <a class="mt-3 text-green-400 inline-flex items-center">Learn More
            <svg fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" class="w-4 h-4 ml-2" viewBox="0 0 24 24">
              <path d="M5 12h14M12 5l7 7-7 7"></path>
            </svg>
          </a>
        </div>
      </div>
      <div class="p-4 md:w-1/3 flex flex-col text-center items-center">
         <img class="circularbox" src="https://i.postimg.cc/8kftKvDd/fifa-20.jpg" alt="fifa20" />
        <div class="flex-grow">
          <h2 class="text-green-500 text-lg title-font font-medium mb-3">FIFA 20</h2>
          <p class="leading-relaxed text-base">New Authentic Game Flow, user-controlled Decisive Moments, and an enhanced Ball Physics System put you at the centre of every match in FIFA 20.
.</p>
          <a class="mt-3 text-green-400 inline-flex items-center">Learn More
            <svg fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" class="w-4 h-4 ml-2" viewBox="0 0 24 24">
              <path d="M5 12h14M12 5l7 7-7 7"></path>
            </svg>
          </a>
        </div>
      </div>
    </div>
  </div>
</section>
        </div>
    </form>
      </asp:Content>