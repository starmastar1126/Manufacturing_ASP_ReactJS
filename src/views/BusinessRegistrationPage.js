import React from 'react';

import Banner from '../components/Banner'

import bgImage from "../assets/img/business_registration.jpeg"

class BusinessRegistrationPage extends React.Component {
  render() {
    return (  
      <div>
        <Banner
          bgImage = {bgImage}
          title = {'Business Registration'}
        />

        <section class="payment_page payment_page_register">
          <div class="container">
            <div class="row">
              <div class="col-md-8">
                <div class="payment_wrapper clearfix">
                  <div class="pay_tle">Company Information Up</div>            
                  <div class="Registration_page">
                    <div class="Registration_col">
                      <div class="account_form">
                        <form>
                          <div class="form-group">
                            <label>Company: <span>*</span></label>
                            <div>
                              <input type="text" class="form-control" id="" placeholder="Enter Company Name"/>
                            </div>
                          </div>
                          <div class="form-group">
                            <label>Category: <span>*</span></label>
                            <div class="sec_category">
                              <span id="" class="link_put">Select Category</span>
                              <a href="#" data-toggle="modal" data-target="#close_category_list"><i class="fa fa-file-text-o" aria-hidden="true"></i> Click here</a>
                            </div>
                          </div>
                          <div class="form-group">
                            <label>First Name: <span>*</span></label>
                            <div>
                              <input type="text" class="form-control" id="" placeholder="Enter First Name"/>
                            </div>
                          </div>
                          <div class="form-group">
                            <label>Last Name: <span>*</span></label>
                            <div>
                              <input type="text" class="form-control" id="" placeholder="Enter Last Name"/>
                            </div>
                          </div>
                          <div class="form-group">
                            <label>Email: <span>*</span></label>
                            <div>
                              <input type="email" class="form-control" id="" placeholder="Enter your Email"/>
                            </div>
                          </div>
                          <div class="form-group">
                            <label>Mobile Number: <span>*</span></label>
                            <div>
                              <input type="text" class="form-control" id="" placeholder="Enter Mobile Number"/>
                            </div>
                          </div>
                          <div class="form-group">
                            <label for="">Password: <span>*</span></label>
                            <div>
                              <input type="password" class="form-control" id="" placeholder="Enter Password"/>
                            </div>
                          </div>
                          <div class="form-group">
                            <label for="">Confirm Password: <span>*</span></label>
                            <div>
                              <input type="password" class="form-control" id="" placeholder="Enter Confirm Password"/>
                            </div>
                          </div>
                          <div class="form-group">
                            <label>Province: <span>*</span></label>
                            <select class="form-control" id="">
                              <option>Select Province </option>
                            </select>
                          </div>
                          <div class="form-group">
                            <label>City: <span>*</span></label>
                            <select class="form-control" id="">
                              <option>Select City </option>
                            </select>
                          </div>
                          <div class="form-group">
                            <label>Suburb: <span>*</span></label>
                            <select class="form-control" id="">
                              <option>Select Suburb </option>
                            </select>
                          </div>

                          <div class="form-group row">               
                            <div class="col-md-12">
                              <div class="form-check">
                                <input class="form-check-input" type="checkbox" id="gridCheck1"/>
                                <label class="form-check-label" for="gridCheck1">
                                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;I agree that the information provided above is true to my knowledge and accept the terms & conditions.
                                </label>
                              </div>
                            </div>   
                          </div>
                        </form>
                      </div>
                    </div>
                  </div>
                  <div class="read_more">
                    <a href="#">Previous</a>
                    <a href="/business-register-payment-page" class="contact_bussiness">Next</a>
                  </div>
                </div>
              </div>
              <div class="col-md-4">
                <div class="order-sec">
                  <div class="pay_tle">Package Summary</div>
                  <div class="order_details clearfix">   
                    <p>Package Cost(A) : <span> R 349.00</span></p>
                    <p>Discount(B) : <span>R 0.00</span></p>
                    <p>VAt(14%)(C) : <span>R 48.86</span></p>
                    <p class="total_amt">Total(A-B+C) : <span>R 397.86</span></p>
                    <div class="clear"></div>
                  </div>   
                </div>
              </div>
            </div>
          </div>
        </section>
      </div>
    );
  }
}

export default BusinessRegistrationPage;
