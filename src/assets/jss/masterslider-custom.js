$(function () {
	"use strict";
 //Master Slider 
  var slider = new MasterSlider();
            // adds Arrows navigation control to the slider.
            slider.control('arrows');
            slider.control('timebar', {insertTo: '#masterslider'});
            slider.control('bullets');
            slider.setup('masterslider', {
                width: 1400, // slider standard width
                height: 700, // slider standard height
                space: 1,
                layout: 'fullwidth',
                loop: true,
                preload: 0,
                instantStartLayers: true,
                autoplay: true
            });
			MSScrollParallax.setup(slider,50,80,true);
			});