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
        <div className="modal-header">
          <button type="button" className="close" data-dismiss="modal" aria-label="Close" onClick={this.props.contactHandler}>
            <span aria-hidden="true">×</span>
          </button>
          <h4 className="modal-title" id="myModalLabel" style={{textAlign: 'center'}}>Contact Bussiness</h4>
        </div>
        <div className="modal-body">
          <input type="hidden" name="ctl00$cphBody$hdnPostFromContactBussiness" id="hdnPostFromContactBussiness" value="0"/>

          <div id="dvRequestDetailsContactBussiness">
            <div className="form-row" style={{textAlign: 'center'}}>
              <label for="txtTitles" accesskey="U">Title*</label>
              <input name="ctl00$cphBody$txtTitles" type="text" id="txtTitles" tabindex="1" className="form-control" placeholder="Enter Title"/>
              <span id="rfvtxtTitles" className="hide">
                <span className="input-error">Please enter Title.</span>
              </span>
            </div>
            <div className="form-row" style={{textAlign: 'center'}}>
              <label for="txtDescriptions " accesskey="U">Description *</label>
              <textarea name="ctl00$cphBody$txtDescriptions" rows="4" cols="20" id="txtDescriptions" tabindex="1" className="form-control" placeholder="Enter Title"></textarea>
              <span id="RequiredFieldValidator1" className="hide">
                <span className="input-error">Please enter Description.</span>
              </span>
            </div>
            <div className="modal-footer text-right">
              <div className="form-group clearfix">
                <input type="button" id="cmdRDNextContactBussiness" className="button next_btt" style={{color: '#fff', background: '#cd2323', padding: '10px', border: 'none'}} value="Next" tabindex="152"/>
              </div>
            </div>
          </div>

          <div id="dvRegisterDetailsContactBussiness" className="hide">
            <h4 className="sec-title">Register</h4>
            <hr className="sec-divider"/>
            <div className="form-group">
              <input type="hidden" name="ctl00$cphBody$HiddenField2" id="HiddenField2" value="0"/>
              <label className="control-label compulsory">Email</label>
              <input name="ctl00$cphBody$txtREmailContactBussiness" type="text" id="txtREmailContactBussiness" tabindex="163" className="form-control" placeholder="Enter Email"/>
              <span id="RequiredFieldValidator2" className="hide">
                <span className="help-block has-error">Please enter email address.</span>
              </span>            
              <span id="CustomValidator1" className="hide">
                <span className="help-block has-error">Please enter valid email address.</span>
              </span>
            </div>
            <div className="form-group">
              <input type="hidden" name="ctl00$cphBody$HiddenField3" id="HiddenField3" value="0"/>
              <label className="control-label compulsory">Mobile Number</label>
              <div className="input-group">
                <span className="input-group-addon">+27 </span>
                <input name="ctl00$cphBody$txtRMobileNumberContactBussiness" type="text" maxlength="9" id="txtRMobileNumberContactBussiness" tabindex="164" className="numeric form-control" placeholder="Enter Mobile Number"/>
              </div>
              <span id="RequiredFieldValidator3" className="hide">
                <span className="help-block has-error">Please enter mobile number</span>
              </span>
              <span id="CustomValidator2" className="hide">
                <span className="help-block has-error">Please valid mobile number</span>
              </span>
            </div>
            <label className="control-label">Login with </label>
            <div className="social-buttons clearfix">
              <a onclick="fb_login(this,1);" tabindex="169" className=" facebook socialIcon">
                <i className="fa fa-facebook"></i>Facebook
              </a>
              <div id="customgprloginContactBussiness" tabindex="170" className="socialIcon" style={{color: '#fff', border: 'none', padding: '10px'}} data-gapiattached="true">
                <i className="fa fa-google-plus"></i>Google+
              </div>
              <a id="linkedInBtnContactBussiness" className="linkedin socialIcon" onclick="jsfn_LinkedInLogin(1)">
                <i className="fa fa-linkedin"></i>LinkedIn
              </a>
            </div>
            <div className="form-group clearfix">
              <div className="pull-right">
                <input type="button" id="cmdRegPrevContactBussiness" className="redBtn" style={{color: '#fff', border: 'none', padding: '10px'}} value="Previous" tabindex="165"/>
                <input type="button" id="cmdRegNextContactBussiness" className="redBtn marginleft10" style={{color: '#fff', border: 'none', padding: '10px'}} value="Request" tabindex="166"/>
              </div>
            </div>
            <div className="clearfix"></div>
          </div>

          <div id="dvLoginDetailsFixedNew" className="hide">
            <h4 className="sec-title">Login</h4>
            <hr className="sec-divider"/>
            <div className="form-group">
              <label className="control-label compulsory">User Name</label>
              <input name="ctl00$cphBody$txtRUserNameContactBussiness" type="text" id="txtRUserNameContactBussiness" tabindex="167" className="control-label form-control"/>
              <span id="RequiredFieldValidator4" className="hide">
                <span className="help-block has-error">Please enter username.</span>
              </span>
            </div>
            <div className="form-group">
              <label className="control-label compulsory">Password</label>
              <input name="ctl00$cphBody$txtRPasswordContactBussiness" type="password" id="txtRPasswordContactBussiness" tabindex="168" className="control-label form-control"/>
              <span id="RequiredFieldValidator5" className="hide">
                <span className="help-block has-error">Please enter password.</span>
              </span>
            </div>
            <div className="form-group clearfix">
              <div className="pull-right">
                <input type="button" id="cmdULPrevContactBussiness" className="redBtn" style={{color: '#fff', border: 'none', padding: '10px'}} value="Previous" tabindex="171"/>
                <input type="button" id="cmdULNextContactBussiness" className="redBtn marginleft10" style={{color: '#fff', border: 'none', padding: '10px'}} value="Login &amp;Request" tabindex="172"/>
              </div>
            </div>
          </div>

          <div id="dvSuccessDetailsContactBussiness"  className="hide">
            <h4 className="sec-title">Request Posted Successfully</h4>
            <hr className="sec-divider"/>
            <div className="form-group">
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
