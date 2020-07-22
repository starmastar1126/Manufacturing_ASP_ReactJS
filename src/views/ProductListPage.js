import React from 'react';
import '@fortawesome/fontawesome-free/css/all.min.css';
import 'bootstrap-css-only/css/bootstrap.min.css';
import 'mdbreact/dist/css/mdb.css';

import '../assets/scss/slider.css';
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";
import '../assets/scss/components/productCard.css';

import InfiniteCarousel from 'react-leaf-carousel';
import Slider from "react-slick";

import ProductCard from "../components/ProductCard";
import ProductSlider from "../components/ProductSlider";

import CategoryPanel from '../components/CategoryPanel';
import CategorySlider from '../components/CategorySlider';
import CategoryCard from '../components/CategoryCard';


import slider1 from '../assets/img/sdetails_img1.jpg'
import slider2 from '../assets/img/special_business.png'
import slider3 from '../assets/img/search_img.jpg'
import slider4 from '../assets/img/product_magazin_image5.jpg'
import slider5 from '../assets/img/search_img.png'
import slider6 from '../assets/img/sdetails_img6.jpg'
import slider7 from '../assets/img/sdetails_img7.jpg'
import slider8 from '../assets/img/product_magazin_image1.jpg'
import slider9 from '../assets/img/special_img2.jpg'

import image11 from '../assets/img/magagin1.jpg'
import image12 from '../assets/img/magagin2.jpg'
import image13 from '../assets/img/magagin3.jpeg'
import image14 from '../assets/img/magagin4.jpg'
import image15 from '../assets/img/magagin21.jpg'
import image16 from '../assets/img/magagin23.jpg'

import image20 from '../assets/img/cat1.jpg'
import image21 from '../assets/img/cat2.jpg'
import image22 from '../assets/img/cat3.png'
import image23 from '../assets/img/cat4.jpg'

import image30 from '../assets/img/product_img02.jpg'
import image31 from '../assets/img/product_magazin_image1.jpg'
import image32 from '../assets/img/product_magazin_image2.jpg'
import image33 from '../assets/img/product_magazin_image6.jpg'

import image40 from '../assets/img/search_img.jpg'
import image41 from '../assets/img/search_img.png'
import image42 from '../assets/img/search_img2.jpg'
import image43 from '../assets/img/search_img3.jpg'

const sliderData = [
  { index: 1, title: 'RH.Chae', image: slider1, price: 'R 1,200', date: '13 May' },
  { index: 2, title: 'NS.Jo', image: slider2, price: 'R 1,200', date: '13 May' },
  { index: 3, title: 'RK.Kim', image: slider3, price: 'R 1,200', date: '13 May' },
  { index: 4, title: 'JH.Han', image: slider4, price: 'R 1,200', date: '13 May' },
  { index: 5, title: 'HJ.Kim', image: slider5, price: 'R 1,200', date: '13 May' },
  { index: 6, title: 'KY.Kim', image: slider6, price: 'R 1,200', date: '13 May' },
  { index: 7, title: 'JM.An', image: slider7, price: 'R 1,200', date: '13 May' },
  { index: 8, title: 'HJ.Ju', image: slider8, price: 'R 1,200', date: '13 May' },
  { index: 9, title: 'JS.Yun', image: slider9, price: 'R 1,200', date: '13 May' }
]

const CategoryData = [
  {
    index: 1, title: '17-Tong-1-3',
    sliders: [
      { silderIndex: 1, sliderTitle: 'RH.Chae', image: image15, fromColor: 'rgba(37, 64, 155, 1)', toColor: 'rgba(37, 64, 155, 0.8)' },
      { silderIndex: 2, sliderTitle: 'NS.Jo', image: image12, fromColor: 'rgba(105, 19, 55, 1)', toColor: 'rgba(115, 29, 65, 0.8)' },
      { silderIndex: 3, sliderTitle: 'RK.Kim', image: image13, fromColor: 'rgba(137, 164, 155, 1)', toColor: 'rgba(147, 174, 165, 0.8)' },
      { silderIndex: 4, sliderTitle: 'JH.Han', image: image14, fromColor: 'rgba(65, 14, 75, 1)', toColor: 'rgba(75, 24, 85, 0.8)' },
      { silderIndex: 5, sliderTitle: 'HJ.Kim', image: image11, fromColor: 'rgba(37, 164, 155, 1)', toColor: 'rgba(47, 174, 165, 0.8)' },
      { silderIndex: 6, sliderTitle: 'KY.Kim', image: image16, fromColor: 'rgba(75, 80, 11, 1)', toColor: 'rgba(85, 90, 21, 0.8)' },
    ],
    products: [
      { productIndex: 1, productTitle: 'NS.Jo', image: image11, price: 'R 1,200', date: '28 May' },
      { productIndex: 2, productTitle: 'HJ.Kim', image: image12, price: 'R 1,200', date: '1 June' },
      { productIndex: 3, productTitle: 'KY.Kim', image: image16, price: 'R 1,200', date: '1 June' },
    ]
  },
  {
    index: 2, title: '17-Tong-1-4',
    sliders: [
      { silderIndex: 1, sliderTitle: 'JM.An', image: image20, fromColor: '#CC7333', toColor: '#CC7444' },
      { silderIndex: 2, sliderTitle: 'HJ.Ju', image: image22, fromColor: '#78768E', toColor: '#87839D' },
      { silderIndex: 3, sliderTitle: 'JS.Yun', image: image23, fromColor: '#7D716B', toColor: '#7D717B' },
    ],
    products: [
      { productIndex: 1, productTitle: 'JM.An', image: image21, price: 'R 1,200', date: '28 May' },
      { productIndex: 2, productTitle: 'HJ.Ju', image: image22, price: 'R 1,200', date: '1 June' },
      { productIndex: 3, productTitle: 'JS.Yun', image: image23, price: 'R 1,200', date: '1 June' },
    ]
  },
  {
    index: 3, title: '17-Tong-1-5',
    sliders: [
      { silderIndex: 1, sliderTitle: 'KH.Ryaeng', image: image30, fromColor: '#333333', toColor: '#444444' },
      { silderIndex: 2, sliderTitle: 'JS.Ko', image: image32, fromColor: '#92A1AA', toColor: '#92A1BB' },
      { silderIndex: 3, sliderTitle: 'UY.Chae', image: image33, fromColor: '#53814D', toColor: '#53815E' },
    ],
    products: [
      { productIndex: 1, productTitle: 'KH.Ryaeng', image: image31, price: 'R 1,200', date: '28 May' },
      { productIndex: 2, productTitle: 'JS.Ko', image: image32, price: 'R 1,200', date: '1 June' },
      { productIndex: 3, productTitle: 'UY.Chae', image: image33, price: 'R 1,200', date: '1 June' },
    ]
  },
  {
    index: 4, title: '17-Tong-2-0',
    sliders: [
      { silderIndex: 1, sliderTitle: 'UH.Jon', image: image40, fromColor: '#333333', toColor: '#444444' },
      { silderIndex: 2, sliderTitle: 'KH.K', image: image42, fromColor: '#92A1AA', toColor: '#92A1BB' },
      { silderIndex: 3, sliderTitle: 'JH.P', image: image43, fromColor: '#53814D', toColor: '#53815E' },
    ],
    products: [
      { productIndex: 1, productTitle: 'UH.Jon', image: image41, price: 'R 1,200', date: '28 May' },
      { productIndex: 2, productTitle: 'KH.K', image: image42, price: 'R 1,200', date: '1 June' },
      { productIndex: 3, productTitle: 'JH.P', image: image43, price: 'R 1,200', date: '1 June' },
    ]
  }
]
const homeItemData = [
  { productIndex: 1, productTitle: 'RH.Chae', image: image11, price: 'R 1,200', date: '28 May' },
  { productIndex: 2, productTitle: 'NS.Jo', image: image12, price: 'R 1,200', date: '1 June' },
  { productIndex: 3, productTitle: 'RK.Kim', image: image13, price: 'R 1,200', date: '1 June' },
  { productIndex: 4, productTitle: 'JH.Han', image: image14, price: 'R 1,200', date: '28 May' },
  { productIndex: 5, productTitle: 'HJ.Ju', image: image15, price: 'R 1,200', date: '1 June' },
  { productIndex: 6, productTitle: 'JS.Yun', image: image16, price: 'R 1,200', date: '1 June' },
  { productIndex: 7, productTitle: 'JM.An', image: image21, price: 'R 1,200', date: '28 May' },
  { productIndex: 8, productTitle: 'HJ.Ju', image: image22, price: 'R 1,200', date: '1 June' },
  { productIndex: 9, productTitle: 'JS.Yun', image: image23, price: 'R 1,200', date: '1 June' },
  { productIndex: 10, productTitle: 'KH.Ryaeng', image: image31, price: 'R 1,200', date: '28 May' },
  { productIndex: 11, productTitle: 'JS.Ko', image: image32, price: 'R 1,200', date: '1 June' },
  { productIndex: 12, productTitle: 'UY.Chae', image: image33, price: 'R 1,200', date: '1 June' },
]

const noOfItems = 12;
const noOfCards = 3;
const autoPlayDelay = 2000;

class ProductListPage extends React.Component {
  state = { activeItemIndex: 0 };

  componentDidMount() { this.interval = setInterval(this.tick, autoPlayDelay); }
  componentWillUnmount() { clearInterval(this.interval); }

  tick = () => this.setState(prevState => ({
    activeItemIndex: (prevState.activeItemIndex + 1) % (noOfItems-noOfCards + 1),
  }));

  onChange = value => this.setState({ activeItemIndex: value });

  render() {
    var settings = { dots: true, infinite: true, speed: 500, slidesToShow: 1, slidesToScroll: 1 };
    return (
      <div>
        <section class="viewspecial">
          <div class="container">
            <div class="col-md-3">
              <div class="left-panel">
                <dl>
                  <dt class="category">Search Filter</dt>
                </dl>
              </div>
              <div>
                
              </div>
            </div>
            <div class="col-md-9">
              <div style={{height: '50px', marginTop: '20px', padding: '12px 0 0 20px', border: '1px solid #000', borderRadius: '5px'}}>
                <a href="#" style={{float: 'left', fontSize: '15px', fontWeight: '300', color: '#000'}}>All Categories >> </a>
                <a href="#" style={{float: 'left', fontSize: '15px', fontWeight: '300', color: '#000'}}>17-Tong-1-3 >> </a> 
                <a href="#" style={{float: 'left', fontSize: '15px', fontWeight: '300', color: '#000'}}>Products</a>
              </div>
              <CategoryPanel category="17-Tong-1">
                <CategoryCard>
                  {homeItemData.map((productItem, productKey) => {
                    return (
                      <div class="col-md-4">   
                        <ProductCard title={productItem.productTitle} image={productItem.image} price={productItem.price} date={productItem.date} />
                        <hr />
                      </div>
                    )
                    ;}                      
                  )}      
                </CategoryCard>
              </CategoryPanel>            
            </div>
          </div>
        </section>
      </div>
    );
  }
}

export default ProductListPage;
