import React from 'react';

class RequestItem extends React.Component {
  render() {
    const { showHideProps} = this.props;
    return (
      <div class={showHideProps === true ? "sticky_bg clearfix open" : "sticky_bg clearfix closed"} id="menu">
        <input type="hidden" name="ctl00$cphBody$hdnPostFromfixed" id="hdnPostFromfixed" value="0" />
        <h3>SUBMIT YOUR REQUEST HERE !!</h3>
        <div class=" search-bannerwraper form">

          <div id="dvRequestDetailsFixed">
            <h4 class="sec-title">SUBMIT ITEM<br/>LET US ASSIST IN WHAT YOU LOOKING FOR</h4>
            <hr class="sec-divider"/>
            <div class="form-group">
              <label class="control-label compulsory">Item Required</label>
              <input name="ctl00$cphBody$txtTitleFixed" type="text" id="txtTitleFixed" class="help-block has-error" placeholder="Item Required"/>
              <span id="rfvtxtTitleFixed" style={{display: 'none'}}>
                <span class="help-block has-error">Item Required</span>
              </span>
            </div>
            <div class="form-group">
              <label class="control-label compulsory">Description</label>
              <textarea name="ctl00$cphBody$txtDescriptionFixed" rows="2" cols="20" id="txtDescriptionFixed" tabindex="151" class="help-block has-error des_box" placeholder="Enter Details Here..."></textarea>
              <span id="rfvtxtDescriptionFixed" style={{display: 'none'}}>
                <span class="help-block has-error">Please Enter Details.</span>
              </span>
            </div>
            <div class="form-group clearfix">
              <input type="button" id="cmdRDNextFixed" class="button next_btt" style={{color: '#fff', padding: '10px', border: 'none'}} value="Next" tabindex="152"/>
            </div>
          </div>

          <div id="dvCategoryDetailsFixed" style={{display: 'none'}}>
            <h4 class="sec-title">Category Information</h4>
            <hr class="sec-divider"/>
            <div class="form-group">
              <label class="control-label compulsory">Category</label>
              <select name="ctl00$cphBody$cboRequestCategoryFixed" id="cboRequestCategoryFixed" tabindex="153" class="form-control">
                <option value="0">Select Category</option>
                <option value="1416">Aerospace  and  Defense</option>
                <option value="1441">Arts  and  Grafts</option>
                <option value="1415">Automotive Manufacturers</option>
                <option value="1337">Chemicals</option>
                <option value="1338">ICT and Electronics</option>
                <option value="1442">Machinery</option>
                <option value="1339">Metals</option>
                <option value="1414">Pharmaceutical</option>
                <option value="1340">Textiles,Clothing  and  Footwear</option>
                <option value="1417">Tooling</option>
                <option value="1418">Waste</option>
              </select>
              <span id="rfvcboRequestCategoryFixed" style={{display: 'none'}}>
                <span class="help-block has-error">Please Select Category.</span>
              </span>
            </div>
            <div class="form-group clearfix">
              <div class="pull-right">
                <input type="button" id="cmdCAPrevFixed" class="redBtn" value="Previous" tabindex="154" style={{color: '#fff', border: 'none', padding: '10px'}}/>
                <input type="button" id="cmdCANextFixed" class="redBtn marginleft10" value="Next" tabindex="155" style={{color: '#fff', border: 'none', padding: '10px'}}/>
              </div>
            </div>
          </div>

          <div id="dvAreaDetailsFixed" style={{display: 'none'}}>
            <h4 class="sec-title">Area Information</h4>
            <hr class="sec-divider"/>
            <div class="form-group">
              <label class="control-label compulsory">Province</label>
              <select name="ctl00$cphBody$cboRequestProvinceFixed" id="cboRequestProvinceFixed" tabindex="156" class="form-control" placeholder="Select Province">
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
              <span id="rfvcboRequestProvinceFixed" style={{display: 'none'}}>
                <span class="help-block has-error">Please Select Province.</span>
              </span>
            </div>
            <div class="form-group">
              <label class="control-label compulsory">City</label>
              <div id="dvcboRequestCityFixed">
                <select name="ctl00$cphBody$cboRequestCityFixed" id="cboRequestCityFixed" tabindex="157" class="form-control" placeholder="Select City">
                  <option value="1280">Alberton</option>
                  <option value="1382">Alexander Bay</option>
                  <option value="1395">Allen Grove</option>
                  <option value="1239">Amanzimtoti</option>
                  <option selected="selected" value="0">Select City</option>
                </select>
              </div>
              <span id="rfvcboRequestCityFixed" style={{display: 'none'}}>
                <span class="help-block has-error">Please Select City.</span>
              </span>
            </div>
            <div class="form-group">
              <label class="control-label compulsory">Suburb</label>
              <div id="dvcboRequestSuburbFixed">
                <select name="ctl00$cphBody$cboRequestSuburbFixed" id="cboRequestSuburbFixed" tabindex="158" class="form-control" placeholder="Select Suburb">
                  <option value="3912">11 Urtel Rd</option>
                  <option value="3885">138 Main Reef Rd</option>
                  <option value="3751">22</option>
                  <option value="3911">236 Zambezi Drive</option>
                  <option value="3941">3 Dynagel St</option>
                  <option value="3890">366 Victoria Road</option>
                  <option selected="selected" value="0">Select Suburb</option>
                </select>
              </div>
              <span id="rfvcboRequestSuburbFixed" style={{display: 'none'}}>
                <span class="help-block has-error">Please Select Suburb.</span>
              </span>
            </div>
            <div class="form-group clearfix">
              <div class="pull-right">
                <input type="button" id="cmdADPrevFixed" class="redBtn" value="Previous" tabindex="159" style={{color: '#fff', border: 'none', padding: '10px'}}/>
                <input type="button" id="cmdADNextFixed" class="redBtn marginleft10" value="Next" tabindex="160" style={{color: '#fff', border: 'none', padding: '10px'}}/>
              </div>
            </div>
          </div>

          <div id="dvImageDetailsFixed" style={{display: 'none'}}>
            <h4 class="sec-title">Upload Photo</h4>
            <hr class="sec-divider"/>
            <div class="form-group">
              <iframe id="ifmUploadFileFixed" name="ifmUploadFileFixed" width="100%" marginheight="0" marginwidth="0" title="Upload File" height="130" scrolling="no" frameborder="0" style={{margin: '0px', padding: '0px'}}></iframe>
            </div>
            <div id="dvlUploadImageFixeds" class="clearfix marginbott10"></div>
            <div class="clearfix">
              <div class="pull-right">
                <input type="button" id="cmdUIPrevFixed" class="redBtn" style={{color: '#fff', border: 'none', padding: '10px'}} value="Previous" tabindex="161"/>
                <input type="button" id="cmdUINextFixed" class="redBtn marginleft10" style={{color: '#fff', border: 'none', padding: '10px'}} value="Next" tabindex="162"/>&nbsp;
              </div>
            </div>
            <br/>
          </div>

          <div id="dvRegisterDetailsFixed" style={{display: 'none'}}>
            <h4 class="sec-title">Register</h4>
            <hr class="sec-divider"/>
            <div class="form-group">
              <input type="hidden" name="ctl00$cphBody$HiddenField1" id="HiddenField1" value="0"/>
              <label class="control-label compulsory">Email</label>
              <input name="ctl00$cphBody$txtREmailFixed" type="text" id="txtREmailFixed" tabindex="163" class="form-control" placeholder="Enter Email"/>
              <span id="rfvtxtREmailFixed" style={{display: 'none'}}>
                <span class="help-block has-error">Please enter email address.</span>
              </span>'
              <span id="cvtxtREmailFixed" style={{display: 'none'}}>
                <span class="help-block has-error">Please enter valid email address.</span>
              </span>
            </div>
            <div class="form-group">
              <input type="hidden" name="ctl00$cphBody$hdnRMobileNumExistsFixed" id="hdnRMobileNumExistsFixed" value="0"/>
              <label class="control-label compulsory">Mobile Number</label>
              <div class="input-group">
                <span class="input-group-addon">+27 </span>
                <input name="ctl00$cphBody$txtRMobileNumberFixed" type="text" maxlength="9" id="txtRMobileNumberFixed" tabindex="164" class="numeric form-control" placeholder="Enter Mobile Number"/>
              </div>
              <span id="rfvtxtRMobileNumberFixed" style={{display: 'none'}}>
                <span class="help-block has-error">Please enter mobile number</span>
              </span>
              <span id="csttxtRMobileNumberFixed" style={{display: 'none'}}>
                <span class="help-block has-error">Please valid mobile number</span>
              </span>
            </div>
            <label class="control-label">Login with </label>
            <div class="col-md-12">
              <ul class="clearfix">
                <li></li>
              </ul>
            </div>
            <div class="social-buttons clearfix">
              <a onclick="fb_login(this,1);" tabindex="169" class=" facebook socialIcon">
                <i class="fa fa-facebook"></i>Facebook
              </a>
              <div id="customgprlogins" tabindex="170" class="socialIcon" style={{color: '#fff', border: 'none', padding: '10px'}} data-gapiattached="true">
                <i class="fa fa-google-plus"></i>Google+
              </div>
              <a id="linkedInBtns" class="linkedin socialIcon" onclick="jsfn_LinkedInLogin(1)">
                <i class="fa fa-linkedin"></i>LinkedIn
              </a>
            </div>
            <div class="form-group clearfix">
              <div class="pull-right">
                <input type="button" id="cmdRegPrevFixed" class="redBtn" style={{color: '#fff', border: 'none', padding: '10px'}} value="Previous" tabindex="165"/>
                <input type="button" id="cmdRegNextFixed" class="redBtn marginleft10" style={{color: '#fff', border: 'none', padding: '10px'}} value="Request" tabindex="166"/>
              </div>
            </div>
            <div class="clearfix"></div>
          </div>

          <div id="dvLoginDetailsFixed" style={{display: 'none'}}>
            <h4 class="sec-title">Login</h4>
            <hr class="sec-divider"/>
            <div class="form-group">
              <label class="control-label compulsory">User Name</label>
              <input name="ctl00$cphBody$txtRUserNameFixed" type="text" id="txtRUserNameFixed" tabindex="167" class="control-label form-control"/>
              <span id="rfvtxtRUserNameFixed" style={{display: 'none'}}>
                <span class="help-block has-error">Please enter username.</span>
              </span>
            </div>
            <div class="form-group">
              <label class="control-label compulsory">Password</label>
              <input name="ctl00$cphBody$txtRPasswordFixed" type="password" id="txtRPasswordFixed" tabindex="168" class="control-label form-control"/>
              <span id="rfvtxtRPasswordFixed" style={{display: 'none'}}>
                <span class="help-block has-error">Please enter password.</span>
              </span>
            </div>
            <div class="form-group clearfix">
              <div class="pull-right">
                <input type="button" id="cmdULPrevFixed" class="redBtn" style={{color: '#fff', border: 'none', padding: '10px'}} value="Previous" tabindex="171"/>
                <input type="button" id="cmdULNextFixed" class="redBtn marginleft10" style={{color: '#fff', border: 'none', padding: '10px'}} value="Login &amp;Request" tabindex="172"/>
              </div>
            </div>
          </div>
          <div id="dvSuccessDetailsFixed" style={{display: 'none'}}>
            <h4 class="sec-title">Request Posted Successfully</h4>
            <hr class="sec-divider"/>
            <div class="form-group">
              Your Request has been posted successfully. Admin will review and approve your request soon.
              <br/>
              <br/>
              Thank you for using Manufacturing EzyFind and good luck with your request! 
            </div>
            <div style={{clear: 'both'}}></div>
          </div>
        </div>
      </div>
    );
  }
}

export default RequestItem;


          