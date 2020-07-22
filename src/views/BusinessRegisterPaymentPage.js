import React from 'react';
import { Link } from 'react-router-dom';

import Banner from '../components/Banner'

import bgImage from "../assets/img/cart_banner.jpg"
import payfastIcon from "../assets/img/payfast_icon.png"
import paypalIcon from "../assets/img/paypal_icon.png"
import paymentIcon from "../assets/img/payment_icon.png"
// import eftLogo from "../assets/img/eft_logo.png"

import Custom from '../assets/jss/Custom.jsx';

class BusinessRegisterPaymentPage extends React.Component {

  state = {
      paymentMethod: 1
  };

  constructor(props) {
    super(props);
    this.handlePaymentMethod = this.handlePaymentMethod.bind(this);
  }

  handlePaymentMethod = (paymentType) => {
    this.setState({ paymentMethod: paymentType });
  }

  render() {
    return (  
      <div>
        <Custom/>
        <Banner
          bgImage = {bgImage}
          title = {'Business Payment Summary'}
        />
        <section className="payment_page">
          <div className="container">
            <div className="row">
              <div className="col-md-9">
                <div className="payment_wrapper clearfix">
                  <div className="pay_tle">Information Summary</div>
                  <div className="payment_details_sec clearfix">
                    <div className="information_col clearfix">
                      <h3>Company Information</h3>
                      <p><span>Company Name: </span>Sed ut perspiciatis</p>
                      <p><span>Company Address: </span>Sed ut perspiciatis unde omnis iste natus error sit voluptatemis</p>
                      <p><span>Company phone No: </span>0123456789</p>
                      <div className="clear"></div>
                    </div> 
                    <div className="information_col clearfix">
                      <h3>main business user information</h3>
                      <p><span>Name: </span>Sed Perspiciatis</p>
                      <p><span>E-mail: </span>example@gmail.com</p>
                      <p><span>Mobile No: </span>0123456789</p>
                      <div className="clear"></div>
                    </div>
                    <div className="note"><span>Note:*</span> Payment above $10,000 is not allowed by PayPal. You can use payfast or eft.</div>
                  </div>
                </div>
              </div>
              <div className="col-md-3">
                <div className="order-sec">
                  <div className="pay_tle">Payment Details</div>
                  <div className="order_details clearfix">
                    <p>Package Cost(A) : <span> R 349.00</span></p>
                    <p>Discount(B) : <span>R 0.00</span></p>
                    <p>VAt(14%)(C) : <span>R 48.86</span></p>
                    <p className="total_amt">Total(A-B+C) : <span>R 397.86</span></p>
                    <div className="clear"></div>
                  </div>   
                </div>
                <div className="payment-method-sec">
                  <div className="pay_tle">Select Payment Method</div>
                  <div className="order_details payment-method-details clearfix">
                    <div className="accordion2">
                      <h3 onClick={() => this.handlePaymentMethod(1)}><img src={payfastIcon} alt=""/></h3>
                      <div className="aaa">
                        <div className="pay_info clearfix">
                          <h4>After payment via PayFast's Secure checkout, your order will be placed</h4>
                          <h4>  PayFast accepts</h4>
                          {/* <div className="pay_card"><a href="#tab1"><img src={paymentIcon} alt=""/></a></div> */}
                          <div className="pay_card"><img src={paymentIcon} alt=""/></div>
                          <div className="paypal_check_btt"><Link to={{ pathname: '/payfast-payment-page', state: { paymentMethod: 1 } }}>Checkout with PayFast</Link></div>
                        </div>
                      </div>
                      <h3 onClick={() => this.handlePaymentMethod(2)}><img src={paypalIcon} alt=""/></h3>
                      <div className="aaa">
                        <div className="pay_info clearfix">
                          <h4>After payment via PayPal's Secure checkout, your order will be placed</h4>
                          <h4>  PayPal accepts</h4>
                          {/* <div className="pay_card"><a href="#tab1"><img src={paymentIcon} alt=""/></a></div> */}
                          <div className="pay_card"><img src={paymentIcon} alt=""/></div>
                          <div className="paypal_check_btt"><Link to={{ pathname: '/paypal-payment-page', state: { paymentMethod: 2 } }}>Checkout with PayPal</Link></div>
                        </div>                                
                      </div>
                      {/* <h3><img src={eftLogo} alt=""/></h3>
                      <div className="aaa">
                        <div className="pay_info clearfix">
                          <div className="eft_area">
                            <form>
                              <div className="form-group">
                                <label for="">POP (Proof Of Payment) number</label>
                                <input type="text" className="form-control" id="" placeholder="Enter your POP number"/>
                              </div>
                              <div id='divHabilitSelectors' className="input-file-container">
                                <p for="">Upload POP documents </p>
                                <input className="input-file" id="fileupload" name="files" type="file" multiple/>
                                <label for="fileupload" className="input-file-trigger" id='labelFU' tabindex="0">Please select a file</label>
                              </div>
                            </form>
                          </div>
                          <div className="paypal_check_btt"><a href="#tab1">Checkout with EFT </a></div>
                        </div>                                
                      </div> */}
                    </div>
                  </div>
                </div>   
                <div className="read_more">
                  <a href="/business-registration-page">Previous</a>
                  <Link className='contact_bussiness' to={{ pathname: '/payment-page', state: { paymentMethod: this.state.paymentMethod } }}>Pay Now</Link>
                </div>
              </div>
            </div>
          </div>
        </section>
      </div>
    );
  }
}

export default BusinessRegisterPaymentPage;
