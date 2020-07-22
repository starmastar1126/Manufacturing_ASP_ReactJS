import React from 'react';

import Banner from '../components/Banner'

import bgImage from "../assets/img/register_banner.jpg"
import fbIcon from "../assets/img/facebook.png"
import gpIcon from "../assets/img/gmail_log.png"
import lnIcon from "../assets/img/linkedin.png"

class LoginPage extends React.Component {
  render() {
    return (
      <div>
        <Banner
          bgImage = {bgImage}
          title = {'Login'}
        />

        <section class="login_area">
          <div class="container">
<div id="parallex-inner" class="container">
            <div class="cart_header clearfix">
              <div class="item_info">Login</div>
              <div class="btt_sec">
                <p>Don't have an account?</p>
                <div class="emty_cart_btt"><a href="/individual-registration-page">Sign Up</a></div>
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
                <form>
                  <div class="form-group">
                    <label> Email:</label>
                    <div>
                      <input name="ctl00$cphBody$txtLoginUserName" type="text" id="txtLoginUserName" tabindex="29" class="form-control" placeholder="Enter email or mobile number"/>
                      <span id="rfvtxtLoginUserName" class="hide">
                        <span class="input-error">Please enter email.</span>
                     </span>
                    </div>
                  </div>   
                  <div class="form-group">
                    <label for="">password:</label>
                    <div>
                      <input name="ctl00$cphBody$txtLoginPassword" type="password" id="txtLoginPassword" tabindex="30" class="form-control" placeholder="Enter Password"/>
                      <span id="rfvtxtLoginPassword" class="hide">
                        <span class="input-error">Please enter password.</span>
                      </span>
                    </div>
                  </div>
                  <div class="form-group row">               
                    <div class="col-md-12">
                      <div class="form-check">
                        <input class="form-check-input" type="checkbox" id="gridCheck1"/>
                        <label class="form-check-label" for="gridCheck1">
                          &nbsp;Remember
                        </label>
                      </div>
                    </div>
                  </div>   
                  <div class="form-group row">  
                    <div class="col-md-4 pull-right">
                      <a href="#" style={{cursor: 'pointer'}}>Forgot Password?</a>
                    </div>       
                    <hr class="sep10"/>     
                    <button type="submit" class="btn btn-primary checkout_sub_btt">Login</button>
                    <hr class="sep20"/>
                  </div>                       
                </form>
                <div class="social_login">
                  <div class="row">
                    <div class="col-md-12">
                      <h3>Social Login</h3>
                      <p>Sign in by one-click with your social accounts.</p>
                    </div>
                    <div class="col-md-12">
                      <ul class="clearfix">
                        <li><a href="#"><img src={fbIcon} alt=""/></a></li>
                        <li><a href="#"><img src={gpIcon} alt=""/></a></li>
                        <li><a href="#"><img src={lnIcon} alt=""/></a></li>
                      </ul>
                    </div>
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
