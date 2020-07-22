import React from 'react';
import { MDBIcon } from "mdbreact";
import '../assets/scss/components/productCard.css';

class ProductCard extends React.Component {

  render() {
    const { title, image, price, date} = this.props;
    return (   
      <a href="#">
        <div class="slider-container">
          <div class="productCard">
            <img class="productImage" style={{marginLeft: '10%', width: '80%', height: '130px', borderRadius: '5px 5px 5px 5px'}} src={image} />
            <div class="container">
              <div>
                <p class="productTitle" style={{padding: '10px 0 0 10px', textAlign: 'left', fontSize: '15px', fontWeight: '500', color:'#000' }}>
                  {title.length > 20 ? title.substring(0, 20) + "...": title}
                </p>
              </div>
              <div class="col-xs-4 col-md-8">
                <p style={{fontSize: '14px', fontWeight: '400', color:'rgb(155, 0, 0)' }}><font style={{fontSize: '14px', fontWeight: '400', color:'rgb(0, 0, 0)' }}>Price:</font> {price}</p>
                <p style={{fontSize: '13px', fontWeight: '400', color:'rgb(0, 100, 0)' }}><font style={{fontSize: '14px', fontWeight: '400', color:'rgb(0, 0, 0)' }}>Ends:</font> {date}</p>
              </div>
              <div class="col-xs-2 col-md-2">
                <p>&nbsp;</p>
                <p style={{fontSize: '14px', fontWeight: '400', color:'#000' }}><MDBIcon icon="cart-plus" /></p>
              </div>
              <div class="col-xs-2 col-md-2">
                <p>&nbsp;</p>
                <p style={{fontSize: '14px', fontWeight: '400', color:'#000' }}><MDBIcon icon="plus-circle" /></p>
              </div>
            </div>
          </div>
        </div>
      </a>
    );
  }
}

export default ProductCard;
