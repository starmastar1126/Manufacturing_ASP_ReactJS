import React from 'react';

import Banner from '../components/Banner'

import bgImage from "../assets/img/cart_banner.jpg"
import payfastIcon from "../assets/img/payfast_icon.png"
import paypalIcon from "../assets/img/paypal_icon.png"
import paymentIcon from "../assets/img/payment_icon.png"
import eftLogo from "../assets/img/eft_logo.png"

class BusinessRegisterPaymentPage extends React.Component {
  render() {
    return (  
      <div>
        <Banner
          bgImage = {bgImage}
          title = {'Business Payment Summary'}
        />
        <section class="payment_page">
          <div class="container">
            <div class="row">
              <div class="col-md-9">
                <div class="payment_wrapper clearfix">
                  <div class="pay_tle">Information Summary</div>
                  <div class="payment_details_sec clearfix">
                    <div class="information_col clearfix">
                      <h3>Company Information</h3>
                      <p><span>Company Name: </span>Sed ut perspiciatis</p>
                      <p><span>Company Address: </span>Sed ut perspiciatis unde omnis iste natus error sit voluptatemis</p>
                      <p><span>Company phone No: </span>0123456789</p>
                      <div class="clear"></div>
                    </div> 
                    <div class="information_col clearfix">
                      <h3>main business user information</h3>
                      <p><span>Name: </span>Sed Perspiciatis</p>
                      <p><span>E-mail: </span>example@gmail.com</p>
                      <p><span>Mobile No: </span>0123456789</p>
                      <div class="clear"></div>
                    </div>
                    <div class="note"><span>Note:*</span> Payment above $10,000 is not allowed by PayPal. You can use payfast or eft.</div>
                  </div>
                </div>
              </div>
              <div class="col-md-3">
                <div class="order-sec">
                  <div class="pay_tle">Payment Details</div>
                  <div class="order_details clearfix">   
                    <p>Package Cost(A) : <span> R 349.00</span></p>
                    <p>Discount(B) : <span>R 0.00</span></p>
                    <p>VAt(14%)(C) : <span>R 48.86</span></p>
                    <p class="total_amt">Total(A-B+C) : <span>R 397.86</span></p>
                    <div class="clear"></div>
                  </div>   
                </div>
                <div class="payment-method-sec">
                  <div class="pay_tle">Select Payment Method</div>
                  <div class="order_details payment-method-details clearfix">   
                    <div class="accordion2">
                      <h3><img src={payfastIcon} alt=""/></h3>
                      <div class="aaa">
                        <div class="pay_info clearfix">
                          <h4>After payment via PayFast's Secure checkout, your order will be placed</h4>
                          <h4>  PayFast accepts</h4>
                          <div class="pay_card"><a href="#tab1"><img src={paymentIcon} alt=""/></a></div>
                          <div class="paypal_check_btt"><a href="#tab1">Checkout with PayFast</a></div>
                        </div>
                      </div>
                      <h3><img src={paypalIcon} alt=""/></h3>
                      <div class="aaa">
                        <div class="pay_info clearfix">
                          <h4>After payment via PayPal's Secure checkout, your order will be placed</h4>
                          <h4>  PayPal accepts</h4>
                          <div class="pay_card"><a href="#tab1"><img src={paymentIcon} alt=""/></a></div>
                          <div class="paypal_check_btt"><a href="#tab1">Checkout with PayPal</a></div>
                        </div>                                
                      </div>
                      <h3><img src={eftLogo} alt=""/></h3>
                      <div class="aaa">
                        <div class="pay_info clearfix">
                          <div class="eft_area">
                            <form>
                              <div class="form-group">
                                <label for="">POP (Proof Of Payment) number</label>
                                <input type="text" class="form-control" id="" placeholder="Enter your POP number"/>
                              </div>
                              <div id='divHabilitSelectors' class="input-file-container">
                                <p for="">Upload POP documents </p>
                                <input class="input-file" id="fileupload" name="files" type="file" multiple/> 
                                <label for="fileupload" class="input-file-trigger" id='labelFU' tabindex="0">Please select a file</label>
                              </div>
                            </form>
                          </div>
                          <div class="paypal_check_btt"><a href="#tab1">Checkout with EFT </a></div>
                        </div>                                
                      </div>
                    </div>
                  </div>
                </div>   
                <div class="read_more">
                  <a href="/business-registration-page">Previous</a>
                  <a href="#" class="contact_bussiness">Pay Now</a>
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
