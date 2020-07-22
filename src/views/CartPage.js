import React from 'react';

import Banner from '../components/Banner'
import Select from '../components/Select'
import BusinessCard from '../components/BusinessCard'
import Pagenation from '../components/Pagenation'
import StockCa from '../components/StockCa'

import bgImage from "../assets/img/prodect_banner_2.jpg"
import productImage from "../assets/img/product_img1.jpg"
import categoryImage from "../assets/img/cart_item_image1.png"

class BusinessListPage extends React.Component {
  render() {
    return (
      <div>
        <Banner
          bgImage = {bgImage}
          title = {'Cart'}
        />

<section className="cart_page cart_page_add">
  <div className="container">
    <div className="row">
      <div className="col-md-9">
        <div className="cart_header clearfix">
          <div className="shipping_btt shipping_btt_add shipping_btt_add_d"><a href="#">Continue Shopping</a></div>
          <div className="item_info">You have 2 items in your cart</div>
          <div className="btt_sec clearfix">
            <div className="shipping_btt shipping_btt_add shipping_btt_add_m"><a href="#">Continue Shopping</a></div>
            <div className="emty_cart_btt emty_cart_btt_m"><a href="#">Empty cart</a></div>
          </div>
        </div> 
        <div className="cart_item_col_page">
          <div className="cart_item_col clearfix">
            <div className="cart_item_image">
              <a href={categoryImage}><img src={categoryImage} alt="Image"/></a>
              {/* <a href={categoryImage}><img src={categoryImage} alt="Image"/></a> */}
            </div>
            <div className="cart_item_details">
              <h2>Appointment Of Sole Selling Agent For A District Or Town</h2>
              <p>Appointment of sole selling agent for a district or town. MEMORANDUM OF AGREEMENT</p>
              <h3>R 99.00</h3>
            </div>
          </div>
          <div className="cart_item_col clearfix">
            <div className="cart_item_image">
              <a href={categoryImage}><img src={categoryImage} alt="Image"/></a>
              {/* <a href={categoryImage}><img src={categoryImage} alt="Image"/></a> */}
            </div>
            <div className="cart_item_details">
              <h2>Appointment Of Sole Selling Agent For A District Or Town</h2>
              <p>Appointment of sole selling agent for a district or town. MEMORANDUM OF AGREEMENT</p>
              <h3>R 99.00</h3>
            </div>
          </div>
        </div>
      </div>
      <div className="col-md-3">
        <div className="cart-order-sec">
          <h2>Your Cart Total</h2>
          <p>R 198.00</p>
          <div className="checkout_btt"><a href="#">Checkout</a></div>
        </div>
      </div> 
    </div>
  </div>
</section>

<section className="related_product related_product_add">
  <div className="container">
    <div className="heading">Related Products</div>
    <div className="related_product_slider">
      <div className="product_col">
        <div className="product_image"><img src={productImage} alt=""/></div>
          <h2>Appointment Of Sole Selling Agent For A District Or Town</h2>
          <p>Appointment of sole selling agent for a district or town. MEMORANDUM OF AGREEMENT</p>
          <div className="price">R 1,500.00</div>
          <div className="btt_area clearfix">
            <div className="buy_now"><a href="#">Buy Now</a></div>
            <div className="cart_btt"><a href="#">Add to cart</a></div>
          </div>
        </div>
        <div className="product_col">
          <div className="product_image"><img src={productImage} alt=""/></div>
          <h2>Appointment Of Sole Selling Agent For A District Or Town</h2>
          <p>Appointment of sole selling agent for a district or town. MEMORANDUM OF AGREEMENT</p>
          <div className="price">R 1,500.00</div>
          <div className="btt_area clearfix">
            <div className="buy_now"><a href="#">Buy Now</a></div>
            <div className="cart_btt"><a href="#">Add to cart</a></div>
          </div>
        </div>
        <div className="product_col">
          <div className="product_image"><img src={productImage} alt=""/></div>
          <h2>Appointment Of Sole Selling Agent For A District Or Town</h2>
          <p>Appointment of sole selling agent for a district or town. MEMORANDUM OF AGREEMENT</p>
          <div className="price">R 1,500.00</div>
          <div className="btt_area clearfix">
              <div className="buy_now"><a href="#">Buy Now</a></div>
              <div className="cart_btt"><a href="#">Add to cart</a></div>
          </div>
        </div>  
        <div className="product_col">
          <div className="product_image"><img src={productImage} alt=""/></div>
          <h2>Appointment Of Sole Selling Agent For A District Or Town</h2>
          <p>Appointment of sole selling agent for a district or town. MEMORANDUM OF AGREEMENT</p>
          <div className="price">R 1,500.00</div>
          <div className="btt_area clearfix">
            <div className="buy_now"><a href="#">Buy Now</a></div>
            <div className="cart_btt"><a href="#">Add to cart</a></div>
          </div>
        </div>
        <div className="product_col">
          <div className="product_image"><img src={productImage} alt=""/></div>
          <h2>Appointment Of Sole Selling Agent For A District Or Town</h2>
          <p>Appointment of sole selling agent for a district or town. MEMORANDUM OF AGREEMENT</p>
          <div className="price">R 1,500.00</div>
          <div className="btt_area clearfix">
            <div className="buy_now"><a href="#">Buy Now</a></div>
            <div className="cart_btt"><a href="#">Add to cart</a></div>
          </div>
        </div>
        <div className="product_col">
          <div className="product_image"><img src={productImage} alt=""/></div>
          <h2>Appointment Of Sole Selling Agent For A District Or Town</h2>
          <p>Appointment of sole selling agent for a district or town. MEMORANDUM OF AGREEMENT</p>
          <div className="price">R 1,500.00</div>
          <div className="btt_area clearfix">
            <div className="buy_now"><a href="#">Buy Now</a></div>
            <div className="cart_btt"><a href="#">Add to cart</a></div>
          </div>
        </div>
      </div>
    </div>
  {/* </div> */}
</section>
      </div>
    );
  }
}

export default BusinessListPage;
