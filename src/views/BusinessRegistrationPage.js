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

        <section className="payment_page payment_page_register">
          <div className="container">
            <div className="row">
              <div className="col-md-8">
                <div className="payment_wrapper clearfix">
                  <div className="pay_tle">Company Information Up</div>
                  <div className="Registration_page">
                    <div className="Registration_col">
                      <div className="account_form">
                        <form>
                          <div className="form-group">
                            <label>Company: <span>*</span></label>
                            <div>
                              <input type="text" className="form-control" id="" placeholder="Enter Company Name"/>
                            </div>
                          </div>
                          <div className="form-group">
                            <label>Category: <span>*</span></label>
                            <div className="sec_category">
                              <span id="" className="link_put">Select Category</span>
                              <a href="#" data-toggle="modal" data-target="#close_category_list"><i className="fa fa-file-text-o" aria-hidden="true"></i> Click here</a>
                            </div>
                          </div>
                          <div className="form-group">
                            <label>First Name: <span>*</span></label>
                            <div>
                              <input type="text" className="form-control" id="" placeholder="Enter First Name"/>
                            </div>
                          </div>
                          <div className="form-group">
                            <label>Last Name: <span>*</span></label>
                            <div>
                              <input type="text" className="form-control" id="" placeholder="Enter Last Name"/>
                            </div>
                          </div>
                          <div className="form-group">
                            <label>Email: <span>*</span></label>
                            <div>
                              <input type="email" className="form-control" id="" placeholder="Enter your Email"/>
                            </div>
                          </div>
                          <div className="form-group">
                            <label>Mobile Number: <span>*</span></label>
                            <div>
                              <input type="text" className="form-control" id="" placeholder="Enter Mobile Number"/>
                            </div>
                          </div>
                          <div className="form-group">
                            <label for="">Password: <span>*</span></label>
                            <div>
                              <input type="password" className="form-control" id="" placeholder="Enter Password"/>
                            </div>
                          </div>
                          <div className="form-group">
                            <label for="">Confirm Password: <span>*</span></label>
                            <div>
                              <input type="password" className="form-control" id="" placeholder="Enter Confirm Password"/>
                            </div>
                          </div>
                          <div className="form-group">
                            <label>Province: <span>*</span></label>
                            <select className="form-control" id="">
                              <option>Select Province </option>
                            </select>
                          </div>
                          <div className="form-group">
                            <label>City: <span>*</span></label>
                            <select className="form-control" id="">
                              <option>Select City </option>
                            </select>
                          </div>
                          <div className="form-group">
                            <label>Suburb: <span>*</span></label>
                            <select className="form-control" id="">
                              <option>Select Suburb </option>
                            </select>
                          </div>

                          <div className="form-group row">
                            <div className="col-md-12">
                              <div className="form-check">
                                <input className="form-check-input" type="checkbox" id="gridCheck1"/>
                                <label className="form-check-label" for="gridCheck1">
                                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;I agree that the information provided above is true to my knowledge and accept the terms & conditions.
                                </label>
                              </div>
                            </div>   
                          </div>
                        </form>
                      </div>
                    </div>
                  </div>
                  <div className="read_more">
                    <a href="/business-package-selection-page">Previous</a>
                    <a href="/business-register-payment-page" className="contact_bussiness">Next</a>
                  </div>
                </div>
              </div>
              <div className="col-md-4">
                <div className="order-sec">
                  <div className="pay_tle">Package Summary</div>
                  <div className="order_details clearfix">
                    <p>Package Cost(A) : <span> R 349.00</span></p>
                    <p>Discount(B) : <span>R 0.00</span></p>
                    <p>VAt(14%)(C) : <span>R 48.86</span></p>
                    <p className="total_amt">Total(A-B+C) : <span>R 397.86</span></p>
                    <div className="clear"></div>
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
