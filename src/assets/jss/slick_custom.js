

$(document).on('ready', function() {
	$(".search_img").slick({
		lazyLoad: 'ondemand', // ondemand progressive anticipated
		infinite: true
		});
	});

$(document).on('ready', function() {
	$(".cart_item_image").slick({
		lazyLoad: 'ondemand', // ondemand progressive anticipated
		infinite: true
		});
	});

	
	$('.related_product_slider').slick({
		dots: false,
		infinite: true,
		speed: 300,
		slidesToShow: 4,
		slidesToScroll: 1,
		autoplay: true,
		dots: true,
		autoplaySpeed: 4000,
		responsive: [
		{
		breakpoint: 1100,
		settings: {
			slidesToShow: 2,
			slidesToScroll:1,
			dots: true
		}
		},
		{
		breakpoint: 1024,
		settings: {
			slidesToShow: 2,
			slidesToScroll: 1,
			dots: true
		}
		},
		{
		breakpoint: 767,
		settings: {
			slidesToShow: 1,
			slidesToScroll: 1,
			dots: true
		}
		},
		{
		breakpoint: 480,
		settings: {
			slidesToShow: 1,
			slidesToScroll: 1,
			dots: true
		}
		}
		
		]
		});
	