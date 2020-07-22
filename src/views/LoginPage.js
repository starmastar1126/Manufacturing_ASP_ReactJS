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

          <section className="login_area">
            <div className="container">
              <div id="parallex-inner" className="container">
                <div className="cart_header clearfix">
                  <div className="item_info">Login</div>
                  <div className="btt_sec">
                    <p>Don't have an account?</p>
                    <div className="emty_cart_btt"><a href="/individual-registration-page">Sign Up</a></div>
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
                    <form>
                      <div className="form-group">
                        <label> Email:</label>
                        <div>
                          <input name="ctl00$cphBody$txtLoginUserName" type="text" id="txtLoginUserName" tabindex="29" className="form-control" placeholder="Enter email or mobile number"/>
                          <span id="rfvtxtLoginUserName" className="hide">
                        <span className="input-error">Please enter email.</span>
                     </span>
                        </div>
                      </div>
                      <div className="form-group">
                        <label for="">password:</label>
                        <div>
                          <input name="ctl00$cphBody$txtLoginPassword" type="password" id="txtLoginPassword" tabindex="30" className="form-control" placeholder="Enter Password"/>
                          <span id="rfvtxtLoginPassword" className="hide">
                        <span className="input-error">Please enter password.</span>
                      </span>
                        </div>
                      </div>
                      <div className="form-group row">
                        <div className="col-md-12">
                          <div className="form-check">
                            <input className="form-check-input" type="checkbox" id="gridCheck1"/>
                            <label className="form-check-label" for="gridCheck1">
                              &nbsp;Remember
                            </label>
                          </div>
                        </div>
                      </div>
                      <div className="form-group row">
                        <div className="col-md-4 pull-right">
                          <a href="#" style={{cursor: 'pointer'}}>Forgot Password?</a>
                        </div>
                        <hr className="sep10"/>
                        <button type="submit" className="btn btn-primary checkout_sub_btt">Login</button>
                        <hr className="sep20"/>
                      </div>
                    </form>
                    <div className="social_login">
                      <div className="row">
                        <div className="col-md-12">
                          <h3>Social Login</h3>
                          <p>Sign in by one-click with your social accounts.</p>
                        </div>
                        <div className="col-md-12">
                          <ul className="clearfix">
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
