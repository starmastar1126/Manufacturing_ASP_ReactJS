import React from 'react';

import Banner from '../components/Banner'

import bgImage from "../assets/img/business_registration.jpeg"
import fbIcon from "../assets/img/facebook.png"
import gpIcon from "../assets/img/gmail_log.png"
import lnIcon from "../assets/img/linkedin.png"

class LoginPage extends React.Component {
  render() {
    return (
      <div>
        <Banner
          bgImage = {bgImage}
          title = {'Sign Up'}
        />

        <section className="login_area">
          <div className="container">
            <div className="cart_header clearfix">
              <div className="item_info">Sign Up</div>
              <div className="btt_sec">
                <p>Already have an account?</p>
                <div className="emty_cart_btt"><a href="/login-page">Sign In</a></div>
              </div>
              <div className="clear"></div>
              <div className="socila_log_area clearfix">
                <div className="log_info">
                  <h3>Social Login</h3>
                  <p>Sign in by one-click with your social accounts.</p>
                </div>
                <div className="log_social">
                  <ul className="clearfix">
                    <li><a href="#"><i className="fa fa-facebook" aria-hidden="true"></i></a></li>
                    <li><a href="#"><i className="fa fa-google-plus" aria-hidden="true"></i></a></li>
                    <li><a href="#"><i className="fa fa-linkedin" aria-hidden="true"></i></a></li>
                  </ul>
                </div>
              </div>
            </div>
            
            <div className="account_sec">
              <div className="tag">We are happy to see you return</div>
              <div className="account_form">
                <div className="form-group">
                  <label for="txtFirstName">First Name: <span>*</span></label>
                  <div>
                    <input name="ctl00$cphBody$txtFirstName" type="text" id="txtFirstName" tabindex="1" className="form-control" placeholder="Enter First Name" maxlength="50"/>
                    <span id="rfvtxtFirstName" className="hide">
                      <span className="input-error">Please enter First Name.</span>
                    </span>                           
                  </div>
                </div>
                <div className="form-group">
                  <label for="txtLastName">Last Name: <span>*</span></label>
                  <div>
                    <input name="ctl00$cphBody$txtLastName" type="text" id="txtLastName" tabindex="2" className="form-control" placeholder="Enter Last Name" maxlength="50"/>
                    <span id="rfvtxtLastName" className="hide">
                      <span className="input-error">Please enter Last Name.</span>
                    </span>                          
                  </div>
                </div>
                <div className="form-group">
                  <input type="hidden" name="ctl00$cphBody$hdnEmailExists" id="hdnEmailExists" value="0"/>
                  <label>Email: <span>*</span></label>
                  <div>
                    <input name="ctl00$cphBody$txtEmail" type="text" id="txtEmail" tabindex="4" className="form-control" placeholder="Enter Email" onchange="javascript:return JS_CheckEmailExists();"/>
                    <span id="rfvtxtEmail" className="hide">
                      <span className="input-error">Please enter email address.</span>
                    </span>
                    <span id="cvtxtEmail" className="hide">
                      <span className="input-error">Please enter valid email address.</span>
                    </span>
                    <span id="cvEmailExist" className="hide">
                      <span className="input-error">Email address already exist</span>
                    </span>                            
                  </div>
                </div>
                <div className="form-group">
                  <input type="hidden" name="ctl00$cphBody$hdnPasswordValid" id="hdnPasswordValid" value="0"/>
                  <label>Password: <span>*</span></label>
                  <div>
                    <input name="ctl00$cphBody$txtPassword" type="password" id="txtPassword" tabindex="5" className="form-control" placeholder="Enter Password"/>
                    <span id="rfvtxtPassword" className="hide">
                      <span className="input-error">Please enter password.</span>
                    </span>
                  </div>
                </div>
                <div className="form-group">
                  <label>Confirm Password: <span>*</span></label>
                  <div>
                    <input name="ctl00$cphBody$txtRepeatPassword" type="password" id="txtRepeatPassword" tabindex="6" className="form-control" placeholder="Enter Confirm Password"/>
                    <span id="rfvtxtRepeatPassword" className="hide">
                      <span className="input-error">Please enter re-enter password.</span>
                    </span>
                    <span id="cvtxtRepeatPassword" className="hide">
                      <span className="input-error">Password does not match.</span>
                    </span>
                  </div>
                </div>
                <div className="form-group ">
                  <label>Province: <span>*</span></label>
                  <div>
                    <select name="ctl00$cphBody$cboProvince" id="cboProvince" tabindex="10" className="selectpicker">
                      <option value="2">Eastern Cape</option>
                      <option value="4">Free State</option>
                      <option value="1">Gauteng</option>
                      <option value="3">KwaZulu Natal</option>
                      <option value="5">Limpopo</option>
                      <option value="6">Mpumalanga</option>
                      <option value="7">North West</option>
                      <option value="8">Northern Cape</option>
                      <option value="9">Western Cape</option>
                      <option selected="selected" value="0">Select Province</option>
                    </select>
                    <span id="rfvcboProvince" className="hide">
                      <span className="input-error">Please Select Province.</span>
                    </span>
                  </div>
                </div>
                <div className="form-group ">
                  <label>City: <span>*</span></label>
                  <div id="dvCity">
                    <select name="ctl00$cphBody$cboCity" id="cboCity" tabindex="11" className="selectpicker">
                      <option value="1280">Alberton</option>
                      <option value="1382">Alexander Bay</option>
                      <option value="1395">Allen Grove</option>
                      <option value="1239">Amanzimtoti</option>
                      <option value="1355">Amanzimtoti</option>
                      <option selected="selected" value="0">Select City</option>
                    </select>
                </div>
                <span id="rfvcboCity" className="hide">
                  <span className="input-error">Please Select City.</span>
                </span>
              </div>
              <div className="form-group ">
                <label>Suburb: <span>*</span></label>
                <div id="dvSuburb">
                  <select name="ctl00$cphBody$cboSuburb" id="cboSuburb" tabindex="12" className="selectpicker">
                    <option value="3912">11 Urtel Rd</option>
                    <option value="3885">138 Main Reef Rd</option>
                    <option value="3751">22</option>
                    <option value="3911">236 Zambezi Drive</option>
                    <option value="3941">3 Dynagel St</option>
                    <option value="3890">366 Victoria Road</option>
                    <option selected="selected" value="0">Select Suburb</option>
                  </select>
                </div>
                <span id="rfvcboSuburb" className="hide">
                  <span className="input-error">Please Select Suburb.</span>
                </span>
              </div>
              <div className="form-group">
                <input type="hidden" name="ctl00$cphBody$hdnMobileNumExists" id="hdnMobileNumExists" value="0"/>
                <label>Mobile Number: <span>*</span></label>
                <div className="input-group">
                  <div className="input-group-addon">+27</div>
                  <input name="ctl00$cphBody$txtMobileNumber" type="text" maxlength="9" id="txtMobileNumber" tabindex="14" className="form-control" placeholder="Enter Mobile Number" onchange="javascript:return JS_CheckContactNumExists();"/>
                </div>
                <span id="rfvMobileNumber" className="hide"><span className="input-error">Please enter mobile number</span></span>
                <span id="cstMobileNumber" className="hide"><span className="input-error">Please valid mobile number</span></span>
                <span id="cvMobileExist" className="hide"><span className="input-error">Mobile number already exist</span></span>
              </div>
              <div className="form-group row">
                <div className="col-md-12">
                  <div className="form-check">
                    <span className="form-check-input"><input id="chkIAgree" type="checkbox" name="ctl00$cphBody$chkIAgree" tabindex="15"/><label for="chkIAgree">&nbsp;I agree the terms &amp; conditions.</label></span>
                  </div>
                  <span id="VFVChkIAgree" className="hide">
                    <span className="input-error">Need to agree &amp; accept the term &amp; conditions.</span>
                  </span>                            
                </div>
              </div>
              <div className="form-group row">
                <div className="col-md-3">
                  <input type="submit" id="btnSignUp" value="Sign Up" className="btn btn-primary checkout_sub_btt" onclick="javascript: return fn_btnSignUpUserClick();" tabindex="16"/>
                </div>
              </div>
              <div className="social_login">
                <div className="row">
                  <div className="col-md-12">
                    <h3>Social Login</h3>
                    <p>Sign in by one-click with your social accounts.</p>
                  </div>
                  <div className="col-md-12">
                    <ul className="clearfix">
                      <li><a href="#" onclick="fb_login(this,0);"><img src={fbIcon} alt=""/></a></li>
                      <li>
                        <div id="customBtn" className="customGPlusSignIn social-btn" style={{cursor: 'pointer'}} data-gapiattached="true">
                          <img src={gpIcon} border="0" alt="Google Login"/>
                        </div>
                      </li>
                      <li>
                        <a id="linkedInBtn" style={{cursor: 'pointer'}} onclick="jsfn_LinkedInLogin(0)"><img src={lnIcon} alt=""/></a>
                      </li>
                    </ul>
                  </div>
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

export default LoginPage;
