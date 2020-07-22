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

        <section class="login_area">
          <div class="container">
            <div class="cart_header clearfix">      
              <div class="item_info">Sign Up</div>
              <div class="btt_sec">
                <p>Already have an account?</p>
                <div class="emty_cart_btt"><a href="/login-page">Sign In</a></div>
              </div>
              <div class="clear"></div>
              <div class="socila_log_area clearfix">
                <div class="log_info">
                  <h3>Social Login</h3>
                  <p>Sign in by one-click with your social accounts.</p>
                </div>
                <div class="log_social">
                  <ul class="clearfix">
                    <li><a href="#"><i class="fa fa-facebook" aria-hidden="true"></i></a></li>
                    <li><a href="#"><i class="fa fa-google-plus" aria-hidden="true"></i></a></li>
                    <li><a href="#"><i class="fa fa-linkedin" aria-hidden="true"></i></a></li>
                  </ul>
                </div>
              </div>
            </div>
            
            <div class="account_sec">
              <div class="tag">We are happy to see you return</div>
              <div class="account_form">
                <div class="form-group">
                  <label for="txtFirstName">First Name: <span>*</span></label>
                  <div>
                    <input name="ctl00$cphBody$txtFirstName" type="text" id="txtFirstName" tabindex="1" class="form-control" placeholder="Enter First Name" maxlength="50"/>
                    <span id="rfvtxtFirstName" class="hide">
                      <span class="input-error">Please enter First Name.</span>
                    </span>                           
                  </div>
                </div>
                <div class="form-group">
                  <label for="txtLastName">Last Name: <span>*</span></label>
                  <div>
                    <input name="ctl00$cphBody$txtLastName" type="text" id="txtLastName" tabindex="2" class="form-control" placeholder="Enter Last Name" maxlength="50"/>
                    <span id="rfvtxtLastName" class="hide">
                      <span class="input-error">Please enter Last Name.</span>
                    </span>                          
                  </div>
                </div>
                <div class="form-group">
                  <input type="hidden" name="ctl00$cphBody$hdnEmailExists" id="hdnEmailExists" value="0"/>
                  <label>Email: <span>*</span></label>
                  <div>
                    <input name="ctl00$cphBody$txtEmail" type="text" id="txtEmail" tabindex="4" class="form-control" placeholder="Enter Email" onchange="javascript:return JS_CheckEmailExists();"/>
                    <span id="rfvtxtEmail" class="hide">
                      <span class="input-error">Please enter email address.</span>
                    </span>
                    <span id="cvtxtEmail" class="hide">
                      <span class="input-error">Please enter valid email address.</span>
                    </span>
                    <span id="cvEmailExist" class="hide">
                      <span class="input-error">Email address already exist</span>
                    </span>                            
                  </div>
                </div>
                <div class="form-group">
                  <input type="hidden" name="ctl00$cphBody$hdnPasswordValid" id="hdnPasswordValid" value="0"/>
                  <label>Password: <span>*</span></label>
                  <div>
                    <input name="ctl00$cphBody$txtPassword" type="password" id="txtPassword" tabindex="5" class="form-control" placeholder="Enter Password"/>
                    <span id="rfvtxtPassword" class="hide">
                      <span class="input-error">Please enter password.</span>
                    </span>
                  </div>
                </div>
                <div class="form-group">
                  <label>Confirm Password: <span>*</span></label>
                  <div>
                    <input name="ctl00$cphBody$txtRepeatPassword" type="password" id="txtRepeatPassword" tabindex="6" class="form-control" placeholder="Enter Confirm Password"/>
                    <span id="rfvtxtRepeatPassword" class="hide">
                      <span class="input-error">Please enter re-enter password.</span>
                    </span>
                    <span id="cvtxtRepeatPassword" class="hide">
                      <span class="input-error">Password does not match.</span>
                    </span>
                  </div>
                </div>
                <div class="form-group ">
                  <label>Province: <span>*</span></label>
                  <div>
                    <select name="ctl00$cphBody$cboProvince" id="cboProvince" tabindex="10" class="selectpicker">
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
                    <span id="rfvcboProvince" class="hide">
                      <span class="input-error">Please Select Province.</span>
                    </span>
                  </div>
                </div>
                <div class="form-group ">
                  <label>City: <span>*</span></label>
                  <div id="dvCity">
                    <select name="ctl00$cphBody$cboCity" id="cboCity" tabindex="11" class="selectpicker">
                      <option value="1280">Alberton</option>
                      <option value="1382">Alexander Bay</option>
                      <option value="1395">Allen Grove</option>
                      <option value="1239">Amanzimtoti</option>
                      <option value="1355">Amanzimtoti</option>
                      <option selected="selected" value="0">Select City</option>
                    </select>
                </div>
                <span id="rfvcboCity" class="hide">
                  <span class="input-error">Please Select City.</span>
                </span>
              </div>
              <div class="form-group ">
                <label>Suburb: <span>*</span></label>
                <div id="dvSuburb">
                  <select name="ctl00$cphBody$cboSuburb" id="cboSuburb" tabindex="12" class="selectpicker">
                    <option value="3912">11 Urtel Rd</option>
                    <option value="3885">138 Main Reef Rd</option>
                    <option value="3751">22</option>
                    <option value="3911">236 Zambezi Drive</option>
                    <option value="3941">3 Dynagel St</option>
                    <option value="3890">366 Victoria Road</option>
                    <option selected="selected" value="0">Select Suburb</option>
                  </select>
                </div>
                <span id="rfvcboSuburb" class="hide">
                  <span class="input-error">Please Select Suburb.</span>
                </span>
              </div>
              <div class="form-group">
                <input type="hidden" name="ctl00$cphBody$hdnMobileNumExists" id="hdnMobileNumExists" value="0"/>
                <label>Mobile Number: <span>*</span></label>
                <div class="input-group">
                  <div class="input-group-addon">+27</div>
                  <input name="ctl00$cphBody$txtMobileNumber" type="text" maxlength="9" id="txtMobileNumber" tabindex="14" class="form-control" placeholder="Enter Mobile Number" onchange="javascript:return JS_CheckContactNumExists();"/>
                </div>
                <span id="rfvMobileNumber" class="hide"><span class="input-error">Please enter mobile number</span></span>
                <span id="cstMobileNumber" class="hide"><span class="input-error">Please valid mobile number</span></span>
                <span id="cvMobileExist" class="hide"><span class="input-error">Mobile number already exist</span></span>
              </div>
              <div class="form-group row">
                <div class="col-md-12">
                  <div class="form-check">
                    <span class="form-check-input"><input id="chkIAgree" type="checkbox" name="ctl00$cphBody$chkIAgree" tabindex="15"/><label for="chkIAgree">&nbsp;I agree the terms &amp; conditions.</label></span>
                  </div>
                  <span id="VFVChkIAgree" class="hide">
                    <span class="input-error">Need to agree &amp; accept the term &amp; conditions.</span>
                  </span>                            
                </div>
              </div>
              <div class="form-group row">
                <div class="col-md-3">
                  <input type="submit" id="btnSignUp" value="Sign Up" class="btn btn-primary checkout_sub_btt" onclick="javascript: return fn_btnSignUpUserClick();" tabindex="16"/>                           
                </div>
              </div>
              <div class="social_login">
                <div class="row">
                  <div class="col-md-12">
                    <h3>Social Login</h3>
                    <p>Sign in by one-click with your social accounts.</p>
                  </div>
                  <div class="col-md-12">
                    <ul class="clearfix">
                      <li><a href="#" onclick="fb_login(this,0);"><img src={fbIcon} alt=""/></a></li>
                      <li>
                        <div id="customBtn" class="customGPlusSignIn social-btn" style={{cursor: 'pointer'}} data-gapiattached="true">
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
