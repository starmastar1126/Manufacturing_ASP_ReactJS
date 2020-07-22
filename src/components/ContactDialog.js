import React from 'react';
import Modal from 'react-awesome-modal';

class ContactDialog extends React.Component {
  
  render() {
    const { visible } = this.props;
    return (
      <Modal 
          visible={visible}
          width="300"
          height="350"
          effect="fadeInDown"
          onClickAway={this.props.contactHandler}
      >
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal" aria-label="Close" onClick={this.props.contactHandler}>
            <span aria-hidden="true">×</span>
          </button>
          <h4 class="modal-title" id="myModalLabel" style={{textAlign: 'center'}}>Contact Bussiness</h4>
        </div>
        <div class="modal-body">
          <input type="hidden" name="ctl00$cphBody$hdnPostFromContactBussiness" id="hdnPostFromContactBussiness" value="0"/>

          <div id="dvRequestDetailsContactBussiness">
            <div class="form-row" style={{textAlign: 'center'}}>
              <label for="txtTitles" accesskey="U">Title*</label>
              <input name="ctl00$cphBody$txtTitles" type="text" id="txtTitles" tabindex="1" class="form-control" placeholder="Enter Title"/>
              <span id="rfvtxtTitles" class="hide">
                <span class="input-error">Please enter Title.</span>
              </span>
            </div>
            <div class="form-row" style={{textAlign: 'center'}}>
              <label for="txtDescriptions " accesskey="U">Description *</label>
              <textarea name="ctl00$cphBody$txtDescriptions" rows="4" cols="20" id="txtDescriptions" tabindex="1" class="form-control" placeholder="Enter Title"></textarea>
              <span id="RequiredFieldValidator1" class="hide">
                <span class="input-error">Please enter Description.</span>
              </span>
            </div>
            <div class="modal-footer text-right">
              <div class="form-group clearfix">
                <input type="button" id="cmdRDNextContactBussiness" class="button next_btt" style={{color: '#fff', background: '#cd2323', padding: '10px', border: 'none'}} value="Next" tabindex="152"/>
              </div>
            </div>
          </div>

          <div id="dvRegisterDetailsContactBussiness" class="hide">
            <h4 class="sec-title">Register</h4>
            <hr class="sec-divider"/>
            <div class="form-group">
              <input type="hidden" name="ctl00$cphBody$HiddenField2" id="HiddenField2" value="0"/>
              <label class="control-label compulsory">Email</label>
              <input name="ctl00$cphBody$txtREmailContactBussiness" type="text" id="txtREmailContactBussiness" tabindex="163" class="form-control" placeholder="Enter Email"/>
              <span id="RequiredFieldValidator2" class="hide">
                <span class="help-block has-error">Please enter email address.</span>
              </span>            
              <span id="CustomValidator1" class="hide">
                <span class="help-block has-error">Please enter valid email address.</span>
              </span>
            </div>
            <div class="form-group">
              <input type="hidden" name="ctl00$cphBody$HiddenField3" id="HiddenField3" value="0"/>
              <label class="control-label compulsory">Mobile Number</label>
              <div class="input-group">
                <span class="input-group-addon">+27 </span>
                <input name="ctl00$cphBody$txtRMobileNumberContactBussiness" type="text" maxlength="9" id="txtRMobileNumberContactBussiness" tabindex="164" class="numeric form-control" placeholder="Enter Mobile Number"/>
              </div>
              <span id="RequiredFieldValidator3" class="hide">
                <span class="help-block has-error">Please enter mobile number</span>
              </span>
              <span id="CustomValidator2" class="hide">
                <span class="help-block has-error">Please valid mobile number</span>
              </span>
            </div>
            <label class="control-label">Login with </label>
            <div class="social-buttons clearfix">
              <a onclick="fb_login(this,1);" tabindex="169" class=" facebook socialIcon">
                <i class="fa fa-facebook"></i>Facebook
              </a>
              <div id="customgprloginContactBussiness" tabindex="170" class="socialIcon" style={{color: '#fff', border: 'none', padding: '10px'}} data-gapiattached="true">
                <i class="fa fa-google-plus"></i>Google+
              </div>
              <a id="linkedInBtnContactBussiness" class="linkedin socialIcon" onclick="jsfn_LinkedInLogin(1)">
                <i class="fa fa-linkedin"></i>LinkedIn
              </a>
            </div>
            <div class="form-group clearfix">
              <div class="pull-right">
                <input type="button" id="cmdRegPrevContactBussiness" class="redBtn" style={{color: '#fff', border: 'none', padding: '10px'}} value="Previous" tabindex="165"/>
                <input type="button" id="cmdRegNextContactBussiness" class="redBtn marginleft10" style={{color: '#fff', border: 'none', padding: '10px'}} value="Request" tabindex="166"/>
              </div>
            </div>
            <div class="clearfix"></div>
          </div>

          <div id="dvLoginDetailsFixedNew" class="hide">
            <h4 class="sec-title">Login</h4>
            <hr class="sec-divider"/>
            <div class="form-group">
              <label class="control-label compulsory">User Name</label>
              <input name="ctl00$cphBody$txtRUserNameContactBussiness" type="text" id="txtRUserNameContactBussiness" tabindex="167" class="control-label form-control"/>
              <span id="RequiredFieldValidator4" class="hide">
                <span class="help-block has-error">Please enter username.</span>
              </span>
            </div>
            <div class="form-group">
              <label class="control-label compulsory">Password</label>
              <input name="ctl00$cphBody$txtRPasswordContactBussiness" type="password" id="txtRPasswordContactBussiness" tabindex="168" class="control-label form-control"/>
              <span id="RequiredFieldValidator5" class="hide">
                <span class="help-block has-error">Please enter password.</span>
              </span>
            </div>
            <div class="form-group clearfix">
              <div class="pull-right">
                <input type="button" id="cmdULPrevContactBussiness" class="redBtn" style={{color: '#fff', border: 'none', padding: '10px'}} value="Previous" tabindex="171"/>
                <input type="button" id="cmdULNextContactBussiness" class="redBtn marginleft10" style={{color: '#fff', border: 'none', padding: '10px'}} value="Login &amp;Request" tabindex="172"/>
              </div>
            </div>
          </div>

          <div id="dvSuccessDetailsContactBussiness"  class="hide">
            <h4 class="sec-title">Request Posted Successfully</h4>
            <hr class="sec-divider"/>
            <div class="form-group">
              Your Request has been posted successfully. Admin will review and approve your request soon.
              <br/>
              <br/>
              Thank you for using ezyfind and good luck with your request! 
            </div>
            <div style={{clear: 'both'}}></div>
          </div>
        </div>
      </Modal>
    );
  }
}

export default ContactDialog;
