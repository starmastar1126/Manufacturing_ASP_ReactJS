/* ALL CUSTOM JS INCLUDED */
$(document).ready(function() {
	RESPONSIVEUI.responsiveTabs();
});

$(document).ready(function(){
	$(".pay_click").click(function () {
	$(".seclect_pay_option_col").slideToggle("slow");
});
});

$(document).ready(function () {
$('#menu-toggle').click(function(){
if($('#menu').hasClass('open')){
	$('#menu').removeClass('open');
	$('#menu-toggle').removeClass('open');
}else{
	$('#menu').addClass('open');
	$('#menu-toggle').addClass('open');
}
});
});

$(document).on('ready', function() {
$(".search_img").slick({
lazyLoad: 'ondemand', // ondemand progressive anticipated
infinite: true
});
});

$(document).on('ready', function() {
$(".product_image").slick({
lazyLoad: 'ondemand', // ondemand progressive anticipated
infinite: true
});
});

$(document).on('ready', function() {
$(".special_image").slick({
lazyLoad: 'ondemand', // ondemand progressive anticipated
infinite: true
});
});

$(document).ready(function() {

	//Default Action
	$(".tab_content").hide(); //Hide all content
	$("ul.tabs li:first").addClass("active").show(); //Activate first tab
	$(".tab_content:first").show(); //Show first tab content
	
	//On Click Event
	$("ul.tabs li").click(function() {
		$("ul.tabs li").removeClass("active"); //Remove any "active" class
		$(this).addClass("active"); //Add "active" class to selected tab
		$(".tab_content").hide(); //Hide all tab content
		var activeTab = $(this).find("a").attr("href"); //Find the rel attribute value to identify the active tab + content
		$(activeTab).fadeIn(); //Fade in the active content
		return false;
	});

});
// payment page
$(document).ready(function(){
	
	$(".accordion2 h3").eq(0).addClass("active");
	$(".aaa").eq(0).show();

	$(".accordion2 h3").click(function(){
		$(this).next(".aaa").slideToggle("slow")
		.siblings(".aaa:visible").slideUp("slow");
		$(this).toggleClass("active");
		$(this).siblings("h3").removeClass("active");
	});

});


$(document).ready(function(){
$(".chat-closed").on("click",function(e){
$(".chat-header,.chat-content").removeClass("hide");
$(this).addClass("hide");
});

$(".chat-header").on("click",function(e){
$(".chat-header,.chat-content").addClass("hide");
$(".chat-closed").removeClass("hide");
});
});


// Initiate Lightbox
$(function() {
$('.product_image a').lightbox(); 
});
$(function() {
$('.search_img a').lightbox(); 
});
$(function() {
$('.special_image a').lightbox(); 
});
$(function() {
$('.cart_item_image a').lightbox(); 
});

// MENU
var FX=function(t,e){return e(".menu-button").click(function(){e(".mobile_primary").toggle({direction:"left"}),e(".menu-button").toggleClass("open"),e(".mainnav .pull--right").toggleClass("open")}),e(".mobile_primary .menu-item-has-children").append('<span class="sub-menu--button"></span>'),e(".sub-menu--button").each(function(){e(this).click(function(){e(this).toggleClass("open"),e(this).prev().slideToggle()})})}(FX||{},jQuery);




/* ----------------
ResponsiveTabs.js
Author: Pete Love | www.petelove.com
Version: 1.5
------------------- */

var RESPONSIVEUI = {};

RESPONSIVEUI.responsiveTabs = function () {
if (!$('.tabs').hasClass('enabled')) {	// if we haven't already enabled tabs
$('.tabs').addClass('enabled'); // used to style tabs if JS is present

//loop through all sets of tabs on the page
var tablistcount = 1;

$('.tabs').each(function() {

	var $tabs = $(this);

	// add tab heading and tab panel classes
	$tabs.children('h1,h2,h3,h4,h5,h6').addClass('tab-heading');
	$tabs.children('div').addClass('tab-panel');

	// determine if markup already identifies the active tab panel for this set of tabs
	// if not then set first heading and tab to be the active one
	var $activePanel = $tabs.find('.active-panel');
	if(!$activePanel.length) {
		var $activePanel = $tabs.find('.tab-panel').first().addClass('active-panel');
	}

	$tabs.find('.tab-panel').not('.active-panel').hide().attr('aria-hidden','true'); //hide all except active panel
	$activePanel.attr('aria-hidden', 'false');
	/* make active tab panel hidden for mobile */
	$activePanel.addClass('hidden-mobile');

	// wrap tabs in container - to be dynamically resized to help prevent page jump
	var $tabsWrapper = $('<div/>', { class: 'tabs-wrapper' });
	$tabs.wrap($tabsWrapper);

	var highestHeight = 0;

	// determine height of tallest tab panel. Used later to prevent page jump when tabs are clicked
	$tabs.find('.tab-panel').each(function() {
		var tabHeight = $(this).height();
		if (tabHeight > highestHeight) {
			highestHeight = tabHeight;
		}
	})

	//create the tab list
	var $tabList = $('<ul/>', { class: 'tab-list', 'role': 'tablist' });

	//loop through each heading in set
	var tabcount = 1;
	$tabs.find('.tab-heading').each(function() {

		var $tabHeading = $(this);
		var $tabPanel = $(this).next();

		$tabHeading.attr('tabindex', 0);

		// CREATE TAB ITEMS (VISIBLE ON DESKTOP)
		//create tab list item from heading
		//associate tab list item with tab panel
		var $tabListItem = $('<li/>', { 
			class: 'tab',
			id: 'tablist' + tablistcount + '-tab' + tabcount,
			'aria-controls': 'tablist' + tablistcount +'-panel' + tabcount,
			'role': 'tab',
			tabindex: 0,
			text: $tabHeading.text(),
			keydown: function (objEvent) {
				if (objEvent.keyCode == 13) { // if user presses 'enter'
					$tabListItem.click();
				}
			},
			click: function() {
				//Show associated panel

				//set height of tab container to highest panel height to avoid page jump
				$tabsWrapper.css('height', highestHeight);

				// remove hidden mobile class from any other panel as we'll want that panel to be open at mobile size
				$tabs.find('.hidden-mobile').removeClass('hidden-mobile');
				
				// close current panel and remove active state from its (hidden on desktop) heading
				$tabs.find('.active-panel').toggle().removeClass('active-panel').attr('aria-hidden','true').prev().removeClass('active-tab-heading');
				
				//make this tab panel active
				$tabPanel.toggle().addClass('active-panel').attr('aria-hidden','false');

				//make the hidden heading active
				$tabHeading.addClass('active-tab-heading');

				//remove active state from currently active tab list item
				$tabList.find('.active-tab').removeClass('active-tab');

				//make this tab active
				$tabListItem.addClass('active-tab');

				//reset height of tab panels to auto
				$tabsWrapper.css('height', 'auto');
			}
		});
		
		//associate tab panel with tab list item
		$tabPanel.attr({
			 'role': 'tabpanel',
			 'aria-labelledby': $tabListItem.attr('id'),
			 id: 'tablist' + tablistcount + '-panel' + tabcount
		 });

		 // if this is the active panel then make it the active tab item
		if($tabPanel.hasClass('active-panel')) {
			$tabListItem.addClass('active-tab');
		}

		// add tab item
		$tabList.append($tabListItem);

		


		// TAB HEADINGS (VISIBLE ON MOBILE)
		// if user presses 'enter' on tab heading trigger the click event
		$tabHeading.keydown(function(objEvent) {
			if (objEvent.keyCode == 13) {
				 $tabHeading.click();
			}
		})

		//toggle tab panel if click heading (on mobile)
		$tabHeading.click(function() {

			// remove any hidden mobile class
			$tabs.find('.hidden-mobile').removeClass('hidden-mobile');

			// if this isn't currently active
			if (!$tabHeading.hasClass('active-tab-heading')){
				//get position of active heading 
				if($('.active-tab-heading').length) {
					var oldActivePos = $('.active-tab-heading').offset().top;
				}
				
				// close currently active panel and remove active state from any hidden heading
				$tabs.find('.active-panel').slideToggle().removeClass('active-panel').prev().removeClass('active-tab-heading');
				
				//close all tabs
				$tabs.find('.tab-panel').hide().attr('aria-hidden','true');

				//open this panel
				$tabPanel.slideToggle().addClass('active-panel').attr('aria-hidden','false');

				// make this heading active
				$tabHeading.addClass('active-tab-heading');

				var $currentActive = $tabs.find('.active-tab');

				//set the active tab list item (for desktop)
				$currentActive.removeClass('active-tab');
				var panelId = $tabPanel.attr('id');
				var tabId = panelId.replace('panel','tab');
				$('#' + tabId).addClass('active-tab');

				//scroll to active heading only if it is below previous one
				var tabsPos = $('.tabs').offset().top;
				var newActivePos = $('.active-tab-heading').offset().top;
				if(oldActivePos < newActivePos) {
					$('html, body').animate({ scrollTop: tabsPos }, 0).animate({ scrollTop: newActivePos }, 400);
				}
				
			}

			// if this tab panel is already active
			else {

				// hide panel but give it special hidden-mobile class so that it can be visible at desktop size
				$tabPanel.removeClass('active-panel').slideToggle(function () { $(this).addClass('hidden-mobile') });

				//remove active heading class
				$tabHeading.removeClass('active-tab-heading');

				//don't alter classes on tabs as we want it active if put back to desktop size
			}
			
		})

		tabcount ++;

	})

	// add finished tab list to its container
	$tabs.prepend($tabList);

	// next set of tabs on page
	tablistcount ++;
})
}
}

// ajout de la classe JS à HTML
document.querySelector("html").classList.add('js');
 
// initialisation des variables
var fileInput  = document.querySelector( ".input-file" ),  
    button     = document.querySelector( ".input-file-trigger" ),
    the_return = document.querySelector(".file-return");
 
// action lorsque la "barre d'espace" ou "Entrée" est pressée
button.addEventListener( "keydown", function( event ) {
    if ( event.keyCode == 13 || event.keyCode == 32 ) {
        fileInput.focus();
    }
});
 
// action lorsque le label est cliqué
button.addEventListener( "click", function( event ) {
   fileInput.focus();
   return false;
});
 
// affiche un retour visuel dès que input:file change
fileInput.addEventListener( "change", function( event ) {  
    //the_return.innerHTML = this.value;
    $('#labelFU').text("file : " + this.value);
});


$(function () {
"use strict";

// Sticky Header   
$(window).on('scroll', function() {
if ($(this).scrollTop() > 100){  
$('.mainnav').addClass("fixed");
}
else{
$('.mainnav').removeClass("fixed");
}
});


$('#summary').scrollToFixed({
	marginTop: $('.header').outerHeight(true) + 0,
	limit: function() {
		var limit = $('.footer').offset().top - $('#summary').outerHeight(true) - 70;
		return limit;
	},
	minWidth:1000,
	zIndex: 9,
	fixed: function() {  },
	dontCheckForPositionFixedSupport: true
});


});


var firstMenuHeight=20;
var secondMenuHeight=20;
jQuery(window).bind('scroll', function()
{
if(jQuery(window).scrollTop()>firstMenuHeight){
	jQuery('.mainnav').addClass('fixed-on-top');}
else{jQuery('.mainnav').removeClass('fixed-on-top');
}
if(jQuery(window).scrollTop()>secondMenuHeight){
jQuery('.mainnav').addClass('fix-menu');
}
else{		
jQuery('.mainnav').removeClass('fix-menu');			
}
});


$( document ).ready(function() {
//alert("jQuery Works!");
setTimeout(function(){
  $('#loader-wrapper').addClass('loaded');		
}, 5000);

});






$(document).ready(function(){

$( ".chat_tab" ).on('click', function() { //#activate is the element you click
$( ".contact-form" ).toggleClass( "js-active" ); // #hidden-element is the element you want to add a class to
});

$( ".mb_contact_tab" ).on('click', function() { //#activate is the element you click
$( ".contact-form" ).toggleClass( "js-active" ); // #hidden-element is the element you want to add a class to
});

});






