/*!
 * Litbx
 * Version: 0.1.0
 * Litbx is a small and easy to use lightbox. It's touch and developer friendly and works just out of the box. It's a lightweight web-plugin based on jQuery.
 * Author: @marcwieland95
 * Site: http://http://marcwieland.ch/
 * Licensed under the MIT license
 */

;(function($, window, document, undefined){
/**
 * --------------------------------
 * Litbx Animation
 * --------------------------------
 * Animation functions
 * @return {Litbx.Animation}
 */

var Animation = function(Litbx, Core) {

	function Module() {}



	return new Module();

};
;/**
 * --------------------------------
 * Litbx Api
 * --------------------------------
 * Plugin api module
 * @return {Litbx.Api}
 */

var Api = function(Litbx, Core) {


	/**
	 * Api Module Constructor
	 */
	function Module() {}


	/**
	 * Api instance
	 * @return {object}
	 */
	Module.prototype.instance = function() {

		return {


		};

	};


	// @return Module
	return new Module();


};
;/**
 * --------------------------------
 * Litbx Arrows
 * --------------------------------
 * Arrows navigation module
 * @return {Litbx.Arrows}
 */

var Arrows = function(Litbx, Core) {


	/**
	 * Arrows Module Constructor
	 */
	function Module() {
		this.build();
		this.collect();
	}

	/**
	 * Build
	 * arrows DOM
	 */
	Module.prototype.build = function() {

		//$( '.' + Litbx.options.classes.inner ).append( Litbx.options.tpl.prev );
		//$( '.' + Litbx.options.classes.inner ).append( Litbx.options.tpl.next );

		// Create arrow after inner-container
		Core.Build.$inner.after( Litbx.options.tpl.prev );
		Core.Build.$inner.after( Litbx.options.tpl.next );

		//$( '.' + Litbx.options.classes.inner ).append( '<span class="' + Litbx.options.classes.arrow + ' ' + Litbx.options.classes.arrowNext + '"></span>' );

	//	this.wrapper = Litbx.slider.find('.' + Glide.options.classes.arrows);
	//	this.items = this.wrapper.children();

	};


	/**
	 * Collect arrow item
	 * arrows DOM
	 */
	Module.prototype.collect = function() {

		this.arrows = $( '.' + Litbx.options.classes.overlay ).find( '.' + Litbx.options.classes.arrow );

	};



	// @return Module
	return new Module();

};
;/**
 * --------------------------------
 * Litbx Build
 * --------------------------------
 * Build slider DOM
 * @param {Litbx} Litbx
 * @param {Core} Core
 * @return {Module}
 */

var Build = function(Litbx, Core) {


	// Build Module Constructor
	function Module() {
		this.init();
	}


	/**
	 * Init lightbox
	 * @param
	 */
	Module.prototype.init = function () {

		var href,
		$overlay;
		//$wrap;

		//console.log( Litbx.element.attr( 'class' ) );
		//console.log( Litbx.element );

		//console.log( $(Litbx.current).index() );

		// Add current class
		Core.Helper.current().addClass( Litbx.options.classes.current );

		//console.log(Litbx.elements);
		//console.log(Litbx.current);


		// Create wrapper
		//$( 'body' ).append( Litbx.options.tpl.wrap );
		//$( Litbx.options.tpl.wrap ).appendTo( 'body' ).after( '<div class="' + Litbx.options.classes.inner + '"></div>' );

		$overlay = $( Litbx.options.tpl.overlay ).appendTo( 'body' );
		this.$wrap = $( Litbx.options.tpl.wrap ).appendTo( $overlay );
		this.$inner = $( Litbx.options.tpl.inner ).appendTo( this.$wrap );

		//console.log( $outer );

			/*
			.append( '<div></div>' )
				.find('div:last').addClass( Litbx.options.classes.wrapper )
				//.append( '<div class="outer"></div>' )
				.append( '<div></div>' )
					.find('div:last').addClass( Litbx.options.classes.inner );
			*/

		//href = Core.Helper.current().attr( 'href' );
		// Insert image - rebuild this - DRY

		//$( '.' + Litbx.options.classes.inner ).append('<img src="" alt="">' ).find('img:last').addClass( Litbx.options.classes.item );

		//$( '.' + Litbx.options.classes.inner ).append('<img src=" ' + href + ' " alt="">' ).find('img:last').addClass( Litbx.options.classes.item );

		// add loading state
		//Core.Images.loading();

		Core.Images.load();

	};


	/**
	 * Destroy lightbox
	 * @param
	 */
	Module.prototype.destroy = function () {

		// Remove wrapper
		$( '.' + Litbx.options.classes.overlay ).remove();

		// Remove classes
		Core.Helper.current()
			.removeClass( Litbx.options.classes.current );

	};

	// @return Module
	return new Module();

};
;/**
 * --------------------------------
 * Litbx Core
 * --------------------------------
 * @param {Litbx} Litbx		Slider Class
 * @param {array} Modules	Modules list to construct
 * @return {Module}
 */

var Core = function (Litbx, Modules) {

	/**
	 * Core Module Constructor
	 * Construct modules and inject Litbx and Core as dependency
	 */
	function Module() {

		for(var module in Modules) {
			this[module] = new Modules[module](Litbx, this);
		}

	}

	// @return Module
	return new Module();

};
;/**
 * --------------------------------
 * Litbx Events
 * --------------------------------
 * Events functions
 * @return {Litbx.Events}
 */

var Events = function(Litbx, Core) {


	/**
	 * Events Module Constructor
	 */
	function Module() {
		this.keyboard();
		this.next();
		this.prev();
		this.close();
		this.resize();
	}


	/**
	 * Keyboard events
	 */
	Module.prototype.keyboard = function() {
		if (Litbx.options.keyboard) {
			$(window).on('keyup.litbx', function(event){
				if (event.keyCode === 39) Core.Run.switch( '>' ); // next
				if (event.keyCode === 37) Core.Run.switch( '<' ); // prev
				if (event.keyCode === 32) Core.Build.destroy(); // close
			});
		}
	};


	/**
	 * Next image
	 */
	Module.prototype.next = function() {

		$( '.' + Litbx.options.classes.arrowNext ).on( 'click.litbx', function() {

			Core.Run.switch( '>' );

			/*
			if ( Core.Run.isEnd() ) {
				Core.Events.unbindArrow();
			}
			*/

			//Core.Run.switch( '>', Litbx.current.index() );
			//console.log ( Litbx.gallery.get( 8 ) );

			//nextItem = Litbx.element.next( '[rel="' + Litbx.galleryRel + '"]' ).addClass('next');

		});
	};


	/**
	 * Prev image
	 */
	Module.prototype.prev = function() {

		$( '.' + Litbx.options.classes.arrowPrev ).on( 'click.litbx', function() {

			Core.Run.switch( '<' );

			/*
			if ( Core.Run.isStart() ) {
				Core.Events.unbindArrow();
			}
			*/

			//Core.Run.switch( '<', Litbx.current.index() );

			//console.log ( Litbx.gallery.get( 8 ) );

			//nextItem = Litbx.element.next( '[rel="' + Litbx.galleryRel + '"]' ).addClass('next');

		});

	};


	/**
	 * Click events - close lightbox
	 */
	Module.prototype.close = function() {

		// Handle click in wrapper (around image)
		$('.' + Litbx.options.classes.overlay ).on( 'click.litbx' , function() {
			Core.Build.destroy();
		})

		// Handle click in image
		.children().on( 'click.litbx', function() {
			if ( !Litbx.options.closeClick ) {
				return false;
			}
		});

	};


	/**
	 * Unbind arrow
	 *
	 * not in use
	 */
	Module.prototype.unbindArrow = function() {

		Core.Arrows.arrows
			.off('click.litbx touchstart.litbx');

		$(window)
			.off('keyup.litbx');

	};


	/**
	 * Browser resize
	 *
	 */
	Module.prototype.resize = function() {

		$(window).on('resize.litbx', this.throttle( function() {
			Core.Images.calculate();
		}, Litbx.options.throttle) );

	};


	/**
	 * Throttle
	 * @source http://underscorejs.org/
	 */
	Module.prototype.throttle = function(func, wait, options) {
		var that = this;
		var context, args, result;
		var timeout = null;
		var previous = 0;
		if (!options) options = {};
		var later = function() {
			previous = options.leading === false ? 0 : Core.Helper.now();
			timeout = null;
			result = func.apply(context, args);
			if (!timeout) context = args = null;
		};
		return function() {
			var now = Core.Helper.now();
			if (!previous && options.leading === false) previous = now;
			var remaining = wait - (now - previous);
			context = this;
			args = arguments;
			if (remaining <= 0 || remaining > wait) {
				if (timeout) {
					clearTimeout(timeout);
					timeout = null;
				}
				previous = now;
				result = func.apply(context, args);
				if (!timeout) context = args = null;
			} else if (!timeout && options.trailing !== false) {
				timeout = setTimeout(later, remaining);
			}
			return result;
		};
	};


	// @return Module
	return new Module();

};
;/**
 * --------------------------------
 * Litbx Helper
 * --------------------------------
 * Helper functions
 * @return {Litbx.Helper}
 */

var Helper = function(Litbx, Core) {


	/**
	 * Helper Module Constructor
	 */
	function Module() {}


	/**
	 * jQuery object of current item
	 * @param shift
	 * @return {jquery object}
	 */
	Module.prototype.current = function( shift ) {

		switch( shift ) {
			case '++':
				return Litbx.elements.eq( Litbx.current + 1 );

			case '--':
				return Litbx.elements.eq( Litbx.current - 1 );

			default:
				return Litbx.elements.eq( Litbx.current );
		}

	};


	/*
		var isPercentage = function(str) {
			return isString(str) && str.indexOf('%') > 0;
		};

		var getScalar = function(orig, dim) {
			var value = parseFloat(orig, 10) || 0;

			if (dim && isPercentage(orig)) {
				value = F.getViewport()[ dim ] / 100 * value;
			}

			return Math.ceil(value);
		};

		var getValue = function(value, dim) {
			return getScalar(value, dim) + 'px';
		};
	 */

	/**
	 * Get time
	 * @source http://underscorejs.org/
	 */
	Module.prototype.now = Date.now || function() {
		return new Date().getTime();
	};


	// @return Module
	return new Module();


};
;/**
 * --------------------------------
 * Litbx Images
 * --------------------------------
 * Image handling
 * @return {Litbx.Images}
 */

var Images = function(Litbx, Core) {

	/**
	 * Image Module Constructor
	 */
	function Module() {

	}


	/**
	 * Load image
	 */
	Module.prototype.load = function() {

		// Load current image
		this.currentImage = new Image();
		this.currentImage.src = Core.Helper.current().attr('href');

		// Add loading spinner
		this.loading();

		// Calc image dimensions
		//this.calculate();

		// Check if gallery has already loaded
		if ( Litbx.builded ) {
			// replace inner content
			Core.Build.$inner.find('img').replaceWith( this.currentImage );
		} else {
			// create inner content
			$( '.' + Litbx.options.classes.inner ).append( this.currentImage ).find('img:last').addClass( Litbx.options.classes.item );
			Litbx.builded = true; // set flag
		}

		// preload next/prev image
		this.preload();

		// image callback
		return this.currentImage;

	};


	/**
	 * Load images - spinner
	 */
	Module.prototype.loading = function() {

		$( this.currentImage ).on('load', function() {

			// Calc image dimensions when image has loaded
			Core.Images.calculate();

			// Remove loading class
			$('.' + Litbx.options.classes.overlay ).removeClass( 'loading' );

			// Fade image in after everything is loaded and renered
			$('.litbx__wrapper').fadeIn();

		}).each(function() {
			// Hide wrapper
			$('.litbx__wrapper').hide();

			// Add loading class to overlay
			$('.' + Litbx.options.classes.overlay ).addClass( 'loading' );
		});

	};


	/**
	 * Preload image
	 */
	Module.prototype.preload = function() {

		if ( Litbx.options.preload ) {

			var image_next,
			image_prev;

			// Preload next image (>)
			image_next = new Image();
			image_next.src = Core.Helper.current( '++' ).attr('href');

			// Preload prev image (<)
			image_prev = new Image();
			image_prev.src = Core.Helper.current( '--' ).attr('href');

		}

	};


	/**
	 * Calculate image size
	 *
	 * Make sure that this function is loaded when image has loaded
	 *
	 */
	Module.prototype.calculate = function() {

		// Check if images is loaded
		if ( this.currentImage.complete ) {
		//Litbx.image_current.onload = function(){
			var width = Litbx.options.width,
			height = Litbx.options.height,
			naturalWidth = this.currentImage.naturalWidth,
			naturalHeight = this.currentImage.naturalHeight,
			ratio = naturalWidth / naturalHeight, // x < 1 = portrait, x > 1 = landscape
			margin = Litbx.options.margin,
			padding = Litbx.options.padding,
			maxWidth = Math.min(Litbx.options.maxWidth, naturalWidth),
			maxHeight = Math.min(Litbx.options.maxHeight, naturalHeight),
			maxViewHeight = $(window).height() - (margin + margin) - (padding + padding), // - margin - padding
			maxViewWidth = $(window).width() - (margin + margin) - (padding + padding),  // - margin - padding
			canExpandHeight,
			canExpandWidth;

			maxViewHeight = Math.min(maxHeight,  maxViewHeight );
			maxViewWidth = Math.min(maxWidth,  maxViewWidth );


			//console.log( ratio );

			//console.log( naturalWidth + ' x ' + naturalHeight );

			/*
				$.each(["Top", "Right", "Bottom", "Left"], function(i, v) {
					if (margin[ i ]) {
						wrap.css('margin' + v, getValue(margin[ i ]));
					}
				});
			 */

			console.log( maxViewHeight );
			console.log( maxViewWidth );


			// set flag for width
			//if ( (margin + padding + width) < Litbx.browserWidth ) {
			if ( width < maxViewWidth ) {
				canExpandWidth = true;
			} else {
				canExpandWidth = false;
			}
			//console.log(canExpandWidth);

			// set flag for height
			//if ( (margin + padding + height ) < Litbx.browserHeight ) {
			if ( height < maxViewHeight ) {
				canExpandHeight = true;
			} else {
				canExpandHeight = false;
			}
			//console.log(canExpandHeight);



			if ( ratio > 1 ) { // landscape
				width = maxViewWidth;
				height = maxViewWidth / ratio;

				if ( height > maxViewHeight ) {
					height = maxViewHeight;
					width = maxViewHeight * ratio;
				}
			}


			if ( ratio < 1 ) { // portrait
				height = maxViewHeight;
				width = maxViewHeight * ratio;

				if ( width > maxViewWidth ) {
					width = maxViewWidth;
					height = maxViewWidth / ratio;
				}
			}


		/*
		if ( Litbx.options.fitToView ) {
			width  = Math.min(maxWidth,  maxViewWidth );
			height = Math.min(maxHeight, maxViewHeight );
		}
		*/

			//Core.Build.$wrap.css({ // undefined ??
			 $( '.' + Litbx.options.classes.wrapper ).css({
				'padding': padding,
				'margin': margin,
				'width': width,
				'height': height,
				//'max-width': maxWidth,
				//'max-height': maxHeight
			});

			//var img_width = image_current.width;
			//var img_height = image_current.height;


			//image.aspectRatio =  image.width / image.height;
			//console.log( image.aspectRatio );

			//console.log( Litbx.browserWidth );
			//console.log( Litbx.browserHeight );

		} else {

			// Image failed to load - return message
			console.log('Image failed to load');

		}

	};


	// @return Module
	return new Module();

};;/**
 * --------------------------------
 * Litbx Run
 * --------------------------------
 * Run logic module
 * @return {Module}
 */

var Run = function(Litbx, Core) {


	/**
	 * Run Module
	 * Constructor
	 */
	function Module() {

	}

	/**
	 * Check if we are on first slide
	 * @return {boolean}
	 */
	Module.prototype.isStart = function() {
		return Litbx.current === 0;
	};


	/**
	 * Check if we are on last slide
	 * @return {boolean}
	 */
	Module.prototype.isEnd = function() {
		return Litbx.current === Litbx.groupLength - 1;
	};


	/**
	 * Switch image
	 * @param direction
	 * @param index
	 */
	Module.prototype.switch = function ( direction, index ) {

		var preloadMedia,
		preloadMediaURL,
		position,
		item;

		// Set current index, when not set
		if ( index === undefined ) {
			//index = Litbx.current.index();
			//index = Litbx.current.index( '[data-group="' + Litbx.groupAttr + '"]' );
			index = Litbx.current;
		}

		// Add active class
		Litbx.elements
			.eq( index ).removeClass( Litbx.options.classes.current );

		// Set current position according to direction
		switch(direction) {

			case '>':
				if ( this.isEnd() ) {

					// do this smarter (if in if)
					if ( Litbx.options.loop) {
						Litbx.current = 0;
					} else {
						Litbx.current = index;
					}

				} else {
					Litbx.current = index + 1;
				}
				break;

			case '<':
				if ( this.isStart() ) {

					// do this smarter (if in if)
					if ( Litbx.options.loop) {
						Litbx.current = Litbx.groupLength - 1;
					} else {
						Litbx.current = index;
					}

				} else {
					Litbx.current = index - 1;
				}
				break;

			case '=':
				Litbx.current = index;
				break;
		}

	/*
		if ( direction === '>' ) {
			Litbx.current = Litbx.elements.eq( index + 1 );
		} else if ( direction === '<' ) {
			Litbx.current = Litbx.elements.eq( index - 1 );
		}
	*/

		//Core.Images.calculate();

		Core.Images.load();

		// nextImage
		//preloadMedia = Litbx.group.eq( Litbx.current.index() ).addClass( Litbx.options.classes.current );
		//preloadMedia = this.$current().addClass( Litbx.options.classes.current );
		//preloadMedia = Core.Helper.current().addClass( Litbx.options.classes.current );
		//preloadMediaURL = preloadMedia.attr( 'href' );

		// Set new active class
		Litbx.elements
			.removeClass( Litbx.options.classes.current )
			.eq( Litbx.current ).addClass( Litbx.options.classes.current );

		// prepare content to replace
		//item = '<img src="' + preloadMediaURL + '" alt="">';

		// replace inner content
		//Core.Build.$inner.find('img').replaceWith( item );

	};

	return new Module();

};
;/**
 * --------------------------------
 * Litbx Touch
 * --------------------------------
 * Touch module
 * @return {Litbx.Touch}
 */

var Touch = function(Litbx, Core) {

	/**
	 * Helper Module Constructor
	 */
	function Module() {}


	// @return Module
	return new Module();

};
;/**
 * --------------------------------
 * Litbx Main
 * --------------------------------
 * Responsible for lightbox init,
 * extending defaults, returning public api
 * @param {jQuery} elements All image elements
 * @param {Object} options Plugin init options
 * @param {jQuery} trigger Root element
 * @return {Litbx}
 */

var Litbx = function ( elements, options, trigger ) {

	/**
	 * Default options
	 * @type {Object}
	 */
	var defaults = {
		padding: 20,
		margin: 70,  // [30, 55, 30, 55]
		arrows: true,  // not in use
		closeBtn: true,  // not in use
		startAt: 0, // int - index starts at 1, 0 or false = open at trigger
		flexbox: false, // not in use

		// Dimensions
		width: 900,
		height: 1200,
		minWidth: 100,  // not in use
		minHeight: 100,  // not in use
		maxWidth: 1600,
		maxHeight: 1600,
		aspectRatio: true,  // not in use
		fitToView: true,  // not in use

		// Events
		closeClick: false,
		preload: true,
		loop: true,
		keyboard: true,
		// nextKeyCode
		// prevKeyCode
		// closeKeyCode
		throttle: 16,

		// Classes
		classes: {
			//base: 'litbx', // not in use
			overlay: 'litbx__overlay',
			wrapper: 'litbx__wrapper',
			inner: 'litbx__inner',
			item: 'litbx__item',
			arrow: 'litbx__arrow',
			arrowNext: 'litbx__arrow--next',
			arrowPrev: 'litbx__arrow--prev',
			current: 'current',
			loading: 'loading',
		},

		// Templates - can't use classes dynamicly here and there is also redundancy
		tpl: {
			overlay: '<div class="litbx__overlay"></div>',
			wrap: '<div class="litbx__wrapper"></div>',
			inner: '<div class="litbx__inner"></div>',
			//error    : '<p class="fancybox-error">{{ERROR}}</p>',
			//closeBtn : '<a title="{{CLOSE}}" class="fancybox-close" href="javascript:;"></a>',
			next: '<span class="litbx__arrow litbx__arrow--prev"><i class="prev">Prev</i></span>',
			prev: '<span class="litbx__arrow litbx__arrow--next"><i class="next">Next</i></span>'
		},

		// Callbacks
		beforeInit: function() {},
		afterInit: function() {},
	};

	// Extend options
	this.options = $.extend({}, defaults, options);

	// Elements
	this.elements = elements;
	this.trigger = trigger;
	this.element = trigger; // deprecated

	// Setup gallery group
	this.group();

	// Collect DOM
	this.collect();

	// Init values
	this.setup();

	this.builded = false; // set flag for first load

	// Call before init callback
	this.options.beforeInit();

	/**
	 * Construct Core with modules
	 * @type {Core}
	 */
	var Engine = new Core(this, {
		Helper: Helper,
		Images: Images,
		Run: Run,
		Animation: Animation,
		Build: Build,
		Arrows: Arrows,
		Events: Events,
		Touch: Touch,
		Api: Api
	});

	// Call after init callback
	this.options.afterInit();

	// api return
	return Engine.Api.instance();

};


/**
 * Setup gallery groups (attr)
 */
Litbx.prototype.group = function() {

	// check if has galleries (groups)
	this.groupAttr = this.trigger.attr('data-group');

	//this.galleryGroup = this.current.attr('data-group') || this.current.attr('rel'); // with rel-attr fallback - handle inside if-statement

	// Check if this image is in a gallery or single
	if ( this.groupAttr !== undefined ) { // maybe set a more useful flag for this -> for later usage

		// cache group selection
		this.group = $( '[data-group="' + this.groupAttr + '"]' );

		// Filter elements with group-attribute
		this.elements = this.elements.filter( this.group );

		//this.trigger = this.trigger.filter( this.group );
		//console.log( this.trigger.index( '[data-group="' + this.groupAttr + '"]' ) );

	} else {

		this.elements = this.trigger;

	}

};


/**
 * Collect DOM
 * and set classes
 */
Litbx.prototype.collect = function() {

	// Set current
	if (this.options.startAt) { // falsy value -> 0 or false
		this.currentIndex = parseInt( this.options.startAt - 1 );
	} else {
		// false: start on trigger image
		//this.currentIndex = this.trigger.index();
		this.currentIndex = this.trigger.index( '[data-group="' + this.groupAttr + '"]' ); // get index relative to group
	}
	this.current = this.currentIndex;
	//console.log(this.current);

	//this.$current = this.elements.eq( this.current );

};


/**
 * Setup properties and values
 */
Litbx.prototype.setup = function() {

	// Group length
	this.length = this.group.length; // deprecated
	this.groupLength = this.group.length;

};;/**
 * Wire Litbx to jQuery
 * @param  {object} options Plugin options
 * @return {object}
 */

$.fn.litbx = function ( options ) {

	// todo: don't allow mulitple trigger on same element
	// return this.each( function () {
		if ( !$.data( this, 'litbx_api' ) ) {
			var $trigger = this;
			// Trigger plugin on click and prevent default link
			$( this ).on( 'click', function( event ) {
				event.preventDefault();
				$.data( this, 'litbx_api',
					// Init plugin instance
					new Litbx( $trigger, options, $(this) )
				);
			});
		}
	// });

};

})(jQuery, window, document);