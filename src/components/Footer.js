import React from 'react';

import fbIcon from "../assets/img/fb.png"
import gpIcon from "../assets/img/gp.png"
import twIcon from "../assets/img/twt.png"
import iosIcon from "../assets/img/ios.png"
import androidIcon from "../assets/img/android.png"
import winIcon from "../assets/img/win.png"

class Footer extends React.Component {
    render() {
        return (
          <div>          
          <section class="footer inner_footer">
            <div class="container">
              <div class="row">
                <div class="col-sm-3">
                  <h3>Quick Links</h3>
                  <ul>
                    <li> <a href="#"><i class="fa fa-angle-right"></i>24/7 Support</a> </li>
                    <li> <a href="#"><i class="fa fa-angle-right"></i>Features</a> </li>
                    <li> <a href="#"><i class="fa fa-angle-right"></i>About Us</a> </li>
                    <li> <a href="#"><i class="fa fa-angle-right"></i>Individual Terms &amp; Conditions</a> </li>
                    <li> <a href="#"><i class="fa fa-angle-right"></i>Business Terms &amp; Conditions</a> </li>
                    <li> <a href="#"><i class="fa fa-angle-right"></i>Privacy Policy</a> </li>
                  </ul>
                </div>
                <div class="col-sm-3">
                  <h3>Get In Touch</h3>
                  <ul>
                    <li>
                      <i class="fa fa-comment"></i>
                      <p> Need help? <br/>
                      <a href="#">24/7 Support online chat.</a> </p>
                    </li>
                    <li>
                      <i class="fa fa-phone"></i>
                      <p><strong>Phone:</strong> 011 056 9123 </p>
                    </li>
                    <li>
                      <i class="fa fa-envelope"></i>
                      <p><strong>Email:</strong> <a href="mailto:info@ezyfind.co.za">info@ezyfind.co.za</a></p>
                    </li>
                  </ul>
                </div>
                <div class="col-sm-3">
                  <h3>Download Apps</h3>
                  <ul>
                    <li><h4><a href="https://itunes.apple.com/us/app/ezyfind/id980233151?ls=1&mt=8"> <img src={iosIcon} alt=""/> iOS App Store</a></h4></li>
                    <li><h4>  <a href="https://play.google.com/store/apps/details?id=com.INNOVEzyFind"><img src={androidIcon} alt=""/> Android Store</a></h4></li>
                    <li><h4><a href="http://www.windowsphone.com/en-in/store/app/ezyfind/6d32b44b-cdb4-4404-8f4d-09542a33934f"><img src={winIcon} alt=""/> Windows Store</a></h4></li>
                  </ul>
                </div>
                <div class="col-sm-3">
                  <h3>Follow Us</h3>
                  <ul class="widget-tabs">
                    <li><h4><a href="#"><img src={fbIcon} alt=""/> Facebook</a></h4></li>
                    <li><h4><a href="#"><img src={gpIcon} alt=""/> Google+</a></h4></li>
                    <li><h4><a href="#"><img src={twIcon} alt=""/> Twitter</a></h4></li>
                  </ul>
                </div>
              </div>
            </div>
          </section>
          <section class="footer">
            <div class="container">
              <div class="row">
                <div class="col-md-6">
                  <p> &copy; 2018 <a href="#">www.manufacturingezyfind.co.za</a> All Rights Reserved.</p>
                </div>
                <div class="col-md-6">
                  <ul>
                    <li><a href="https://www.facebook.com/LawyersEzyFind.co.za/" class="fb"><i class="fab fa-facebook-f"></i></a></li>               
                    <li><a href="https://plus.google.com/111975390368301243237" class="gp"><i class="fab fa-google-plus-g"></i></a></li>
                    <li><a href="https://twitter.com/search?f=tweets&q=LawyersEzyFind.co.za" class="rs"><i class="fab fa-twitter"></i></a></li>
                  </ul>
                </div>
              </div>
            </div>
          </section>
          </div>
        );
    }
}

export default Footer;
